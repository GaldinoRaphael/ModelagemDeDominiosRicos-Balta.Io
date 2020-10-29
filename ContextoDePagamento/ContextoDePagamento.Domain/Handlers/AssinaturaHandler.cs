using System;
using ContextoDePagamento.Domain.Commands;
using ContextoDePagamento.Domain.Entidades;
using ContextoDePagamento.Domain.Repositories;
using ContextoDePagamento.Domain.ValueObjects;
using ContextoDePagamento.Shared.Handlers;
using ContextoDePamento.Domain.Services;
using Flunt.Notifications;

namespace ContextoDePagamento.Domain.Handlers
{
    public class AssinaturaHandler : Notifiable, IHandler<CriaUmaAssinaturaBoletoCommand>
    {
        private readonly IEstudanteRepositorio _respositorio;
        private readonly IEmailService _emailService;
        public AssinaturaHandler(IEstudanteRepositorio repositorio,
                                IEmailService emailService)
        {
            _respositorio = repositorio;
            _emailService = emailService;
        }
        public ICommandResult Handle(CriaUmaAssinaturaBoletoCommand command)
        {
            //fail fast validations
            command.Validacao();
            if (command.Invalid)
                return new CommandResult(false, "Não foi possível realizar a assinatura");

            //Verificar se documento já está cadastrado
            if (_respositorio.DocumentoExiste(command.Documento))
                AddNotification("Documento", "Este CPF já está em uso");

            //Verificar se email já está cadastrado
            if (_respositorio.DocumentoExiste(command.Email))
                AddNotification("Documento", "Este Email já está em uso");

            //Gerar os VOs
            var nome = new Nome(command.PrimeiroNome, command.SobreNome);
            var documento = new Documento(command.Documento, Domain.Enums.EDocumentoTipo.cpf);
            var email = new Email(command.Email);
            var endereco = new Endereco(command.Rua, command.Numero, command.Bairro, command.Cidade, command.Pais, command.Cep);

            //Gerar as entidades
            var estudante = new Estudante(nome, documento, email);
            var assinatura = new Assinatura(DateTime.Now.AddMonths(1));
            var pagamento = new PagamentoNoBoleto(command.CodigoDeBarras,
                command.NumeroDoBoleto,
                command.DataDoPagamento,
                command.DataDeExpiracao,
                command.Total,
                command.TotalPago,
                command.Pagante,
                new Documento(command.DocumentoDoPagante, command.TipoDoDocumentoDoPagante),
                endereco,
                email);

            //Relacionamento
            assinatura.AdicionaPagamento(pagamento);
            estudante.AdicionarAssinatura(assinatura);

            //Aplicar validações
            AddNotifications(nome, documento, email, endereco, estudante, pagamento);

            //Salvar as informações
            _respositorio.CriaAssinatura(estudante);

            //Enviar E-mail de boas vindas
            _emailService.Enviar(estudante.Nome.ToString(),
                estudante.Email.Endereco,
                "Bem vindo ao balta IO",
                "Sua Assinatura foi criada!");
            //REtornar informações
            return new CommandResult(true, "Assinatura Realizada com sucesso");
        }
    }
}