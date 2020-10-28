using System;
using System.Collections.Generic;
using System.Linq;

namespace ContextoDePagamento.Domain.Entidades
{
    public class Assinatura
    {
        private IList<Pagamento> _pagamentos;
        public Assinatura(DateTime dataDeExpiracao)
        {
            DataDeCriacao = DateTime.Now;
            DataDaUltimaAtualizacao = DateTime.Now;
            DataDeExpiracao = dataDeExpiracao;
            Ativo = true;
            _pagamentos = new List<Pagamento>();
        }

        public DateTime DataDeCriacao { get; set; }
        public DateTime DataDaUltimaAtualizacao { get; set; }
        public DateTime DataDeExpiracao { get; set; }
        public bool Ativo { get; set; }
        public IReadOnlyCollection<Pagamento> Pagamentos { get { return _pagamentos.ToArray(); } }

        public void AdicionaPagamento(Pagamento pagamento)
        {
            _pagamentos.Add(pagamento);
        }

        public void Ativar()
        {
            Ativo = true;
            DataDaUltimaAtualizacao = DateTime.Now;
        }
        public void Desativar()
        {
            Ativo = false;
            DataDaUltimaAtualizacao = DateTime.Now;
        }
    }
}