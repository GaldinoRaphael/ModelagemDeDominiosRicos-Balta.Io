using System;
using System.Collections.Generic;

namespace ContextoDePagamento.Domain.Entidades
{
    public class Assinatura
    {
        public DateTime DataDeCriacao { get; set; }
        public DateTime DataDaUltimaAtualizacao { get; set; }
        public DateTime DataDeExpiracao { get; set; }
        public bool Ativo { get; set; }
        public List<Pagamento> Pagamentos { get; set; }
    }
}