using System;

namespace ContextoDePagamento.Domain.Entidades
{
    public class PagamentoNoPayPal : Pagamento
    {
        public PagamentoNoPayPal(
            string codigoDeTransacao,
            DateTime dataDoPagamento,
            DateTime dataDeExpiracao,
            decimal total,
            decimal totalPago,
            string pagante,
            string documento,
            string endereco,
            string email)
        : base(dataDoPagamento, dataDeExpiracao, total, totalPago, pagante, documento, endereco, email)
        {
            CodigoDeTransacao = codigoDeTransacao;
        }

        public string CodigoDeTransacao { get; private set; }
    }

}