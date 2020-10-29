using System;
using ContextoDePagamento.Domain.Commands;
using ContextoDePagamento.Domain.Entidades;
using ContextoDePagamento.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContextoDePagamento.Tests
{
    [TestClass]
    public class CriaUmaAssinaturaBoletoCommandTestes
    {
        [TestMethod]
        public void DeveRetornarErroQuandoNomeEhInvalido()
        {
            var command = new CriaUmaAssinaturaBoletoCommand();
            command.PrimeiroNome = "";

            command.Validacao();
            Assert.AreEqual(false, command.Valid);
        }
    }
}
