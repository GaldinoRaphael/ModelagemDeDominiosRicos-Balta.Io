using System.Collections.Generic;
using System.Linq;
using ContextoDePagamento.Domain.ValueObjects;
using ContextoDePagamento.Shared.Entidades;

namespace ContextoDePagamento.Domain.Entidades
{
    public class Estudante : Entidade
    {
        private IList<Assinatura> _assinaturas;
        public Estudante(Nome nome, Documento documento, Email email)
        {
            Nome = nome;
            Documento = documento;
            Email = email;
            _assinaturas = new List<Assinatura>();

            AddNotifications(nome, documento, email);
        }

        public Nome Nome { get; private set; }
        public Documento Documento { get; private set; }
        public Email Email { get; private set; }
        public Endereco Endereco { get; private set; }
        public IReadOnlyCollection<Assinatura> Assinaturas { get { return _assinaturas.ToArray(); } }
        public void AdicionarAssinatura(Assinatura assinatura)
        {
            foreach (var ass in Assinaturas)
            {
                ass.Desativar();
            }

            _assinaturas.Add(assinatura);
        }
    }
}