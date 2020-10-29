using System;
using ContextoDePagamento.Domain.Entidades;
using ContextoDePagamento.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContextoDePagamento.Tests
{
    [TestClass]
    public class EstudanteTestes
    {
        private readonly Estudante _estudante;
        private readonly Assinatura _assinatura;
        private readonly Nome _nome;
        private readonly Documento _documento;
        private readonly Email _email;
        private readonly Endereco _endereco;
        public EstudanteTestes()
        {
            _nome = new Nome("Bruce", "Wayne");
            _documento = new Documento("35111507795", Domain.Enums.EDocumentoTipo.cpf);
            _email = new Email("batman@dc.com");
            _endereco = new Endereco("Rua 1", "1234", "Bairro Legal", "Gotham", "SP", "BR", "13400000");
            var _estudante = new Estudante(_nome, _documento, _email);
            var _assinatura = new Assinatura(DateTime.Now.AddDays(10));

        }
        [TestMethod]
        public void DeveRetornarErroQuandoOAlunoTemUmaAssinaturaAtiva()
        {
            var pagamento = new PagamentoNoPayPal("12345879", DateTime.Now, DateTime.Now.AddDays(5), 10, 10, "Wayne Corp", _documento, _endereco, _email);
            _assinatura.AdicionaPagamento(pagamento);
            _estudante.AdicionarAssinatura(_assinatura);
            _estudante.AdicionarAssinatura(_assinatura);

            Assert.IsTrue(_estudante.Invalid);
        }
        public void DeveRetornarErroQuandoOAssinaturaNaoTemPagamento()
        {
            _estudante.AdicionarAssinatura(_assinatura);
            _estudante.AdicionarAssinatura(_assinatura);

            Assert.IsTrue(_estudante.Invalid);
        }
        [TestMethod]
        public void DeveRetornarSucessoQuandoOAlunoNaoTemUmaAssinaturaAtiva()
        {
            var pagamento = new PagamentoNoPayPal("12345879", DateTime.Now, DateTime.Now.AddDays(5), 10, 10, "Wayne Corp", _documento, _endereco, _email);
            _assinatura.AdicionaPagamento(pagamento);
            _estudante.AdicionarAssinatura(_assinatura);
            _estudante.AdicionarAssinatura(_assinatura);

            Assert.IsTrue(_estudante.Valid);
        }
    }
}
