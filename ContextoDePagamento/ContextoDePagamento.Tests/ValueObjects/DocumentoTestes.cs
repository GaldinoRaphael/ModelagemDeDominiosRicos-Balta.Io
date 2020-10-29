using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContextoDePagamento.Domain.Entidades;
using ContextoDePagamento.Domain.ValueObjects;
using ContextoDePagamento.Domain.Enums;

namespace ContextoDePagamento.Tests
{
    [TestClass]
    public class DocumentoTestes
    {
        //Red, green, Refactor
        [TestMethod]
        public void DeveRetornarErroQuandoCNPJEhInvalido()
        {
            var doc = new Documento("123", EDocumentoTipo.cnpj);
            Assert.IsTrue(doc.Invalid);
        }
        [TestMethod]
        public void DeveRetornarSucessoQuandoCNPJEhValido()
        {
            var doc = new Documento("34110468000150", EDocumentoTipo.cnpj);
            Assert.IsTrue(doc.Valid);
        }
        [TestMethod]
        public void DeveRetornarErroQuandoCPFEhInvalido()
        {
            var doc = new Documento("123", EDocumentoTipo.cpf);
            Assert.IsTrue(doc.Invalid);
        }
        [TestMethod]
        [DataTestMethod]
        [DataRow("34225545806")]
        [DataRow("54139739347")]
        [DataRow("01077284608")]
        public void DeveRetornarSucessoQuandoCPFEhValido(string cpf)
        {
            var doc = new Documento(cpf, EDocumentoTipo.cpf);
            Assert.IsTrue(doc.Valid);
        }
    }
}