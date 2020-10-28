using System;
using ContextoDePagamento.Domain.ValueObjects;

namespace ContextoDePagamento.Domain.Entidades
{
    public class PagamentNoCartaoDeCredito : Pagamento
    {
        public PagamentNoCartaoDeCredito(
        string nomeDoTitularDoCartao,
        string numeroDoCartao,
        string numeroDaUltimaTransacao,
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
            NomeDoTitularDoCartao = nomeDoTitularDoCartao;
            NumeroDoCartao = numeroDoCartao;
            NumeroDaUltimaTransacao = numeroDaUltimaTransacao;
        }

        public string NomeDoTitularDoCartao { get; private set; }
        public string NumeroDoCartao { get; private set; }
        public string NumeroDaUltimaTransacao { get; private set; }
    }

}