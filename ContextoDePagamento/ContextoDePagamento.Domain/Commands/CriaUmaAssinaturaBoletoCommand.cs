using System;
using ContextoDePagamento.Domain.Enums;
using ContextoDePagamento.Domain.ValueObjects;
using ContextoDePagamento.Shared.Commands;
using Flunt.Notifications;
using Flunt.Validations;

namespace ContextoDePagamento.Domain.Commands
{
    public class CriaUmaAssinaturaBoletoCommand : Notifiable, ICommand
    {
        public string PrimeiroNome { get; set; }
        public string SobreNome { get; set; }
        public string Documento { get; set; }
        public EDocumentoTipo Tipo { get; set; }
        public string Email { get; set; }
        public string CodigoDeBarras { get; set; }
        public string NumeroDoBoleto { get; set; }
        public string NumeroDePagamento { get; set; }
        public DateTime DataDoPagamento { get; set; }
        public DateTime DataDeExpiracao { get; set; }
        public decimal Total { get; set; }
        public decimal TotalPago { get; set; }
        public string Pagante { get; set; }
        public string DocumentoDoPagante { get; set; }
        public EDocumentoTipo TipoDoDocumentoDoPagante { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public string Cep { get; set; }
        public Email PaganteEmail { get; set; }

        public void Validacao()
        {
            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(PrimeiroNome, 3, "Nome.PrimeiroNome", "Nome inválido")
                .HasMaxLen(SobreNome, 3, "Nome.SobreNome", "Nome inválido"));
        }
    }
}