using System;

namespace ContextoDePagamento.Domain.Entidades
{
    public abstract class Pagamento
    {
        public Pagamento(DateTime dataDoPagamento, DateTime dataDeExpiracao, decimal total, decimal totalPago, string pagante, string documento, string endereco, string email)
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
        public string Documento { get; private set; }
        public string Endereco { get; private set; }
        public string Email { get; private set; }
    }
}