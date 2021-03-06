using System;
using ContextoDePagamento.Domain.ValueObjects;

namespace ContextoDePagamento.Domain.Entidades
{
    public class PagamentoNoBoleto : Pagamento
    {
        public PagamentoNoBoleto(
            string codigoDeBarras,
            string numeroDoBoleto,
            DateTime dataDoPagamento,
            DateTime dataDeExpiracao,
            decimal total,
            decimal totalPago,
            string pagante,
            Documento documento,
            Endereco endereco,
            Email email)
        : base(dataDoPagamento, dataDeExpiracao, total, totalPago, pagante, documento, endereco, email)
        {
            CodigoDeBarras = codigoDeBarras;
            NumeroDoBoleto = numeroDoBoleto;
        }

        public string CodigoDeBarras { get; private set; }
        public string NumeroDoBoleto { get; private set; }
    }

}