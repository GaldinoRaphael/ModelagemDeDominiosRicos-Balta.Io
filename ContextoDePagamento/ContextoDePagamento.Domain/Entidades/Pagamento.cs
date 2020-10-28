using System;

namespace ContextoDePagamento.Domain.Entidades
{
    public abstract class Pagamento
    {
        public string Number { get; set; }
        public DateTime DataDoPagamento { get; set; }
        public DateTime DataDeExpiracao { get; set; }
        public decimal Total { get; set; }
        public decimal TotalPago { get; set; }
        public string Pagante { get; set; }
        public string Documento { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
    }
    public class PagamentoNoBoleto : Pagamento
    {
        public string CodigoDeBarras { get; set; }
        public string NumeroDoBoleto { get; set; }
    }
    public class PagamentNoCartaoDeCredito : Pagamento
    {
        public string NomeDoTitularDoCartao { get; set; }
        public string NumeroDoCartao { get; set; }
        public string NumeroDaUltimaTransacao { get; set; }
    }
    public class PagamentoNoPayPal : Pagamento
    {
        public string CodigoDeTransacao { get; set; }
    }

}