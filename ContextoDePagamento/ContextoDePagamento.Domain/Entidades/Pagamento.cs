using System;
using ContextoDePagamento.Domain.ValueObjects;
using ContextoDePagamento.Shared.Entidades;

namespace ContextoDePagamento.Domain.Entidades
{
    public abstract class Pagamento : Entidade
    {
        public Pagamento(DateTime dataDoPagamento, DateTime dataDeExpiracao, decimal total, decimal totalPago, string pagante, Documento documento, Endereco endereco, Email email)
        {
            Numero = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 10).ToUpper();
            DataDoPagamento = dataDoPagamento;
            DataDeExpiracao = dataDeExpiracao;
            Total = total;
            TotalPago = totalPago;
            Pagante = pagante;
            Documento = documento;
            Endereco = endereco;
            Email = email;
        }

        public string Numero { get; private set; }
        public DateTime DataDoPagamento { get; private set; }
        public DateTime DataDeExpiracao { get; private set; }
        public decimal Total { get; private set; }
        public decimal TotalPago { get; private set; }
        public string Pagante { get; private set; }
        public Documento Documento { get; private set; }
        public Endereco Endereco { get; private set; }
        public Email Email { get; private set; }
    }
}