using System.Collections.Generic;
using System.Linq;

namespace ContextoDePagamento.Domain.Entidades
{
    public class Estudante
    {
        private IList<Assinatura> _assinaturas;
        public Estudante(string primeiroNome, string ultimoNome, string documento, string email)
        {
            PrimeiroNome = primeiroNome;
            UltimoNome = ultimoNome;
            Documento = documento;
            Email = email;
            _assinaturas = new List<Assinatura>();
        }

        public string PrimeiroNome { get; private set; }
        public string UltimoNome { get; private set; }
        public string Documento { get; private set; }
        public string Email { get; private set; }
        public string Endereco { get; private set; }
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