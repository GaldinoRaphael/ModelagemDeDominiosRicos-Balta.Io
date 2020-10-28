using ContextoDePagamento.Shared.ValueObjects;

namespace ContextoDePagamento.Domain.ValueObjects
{
    public class Nome : ValueObject
    {
        public Nome(string primeiroNome, string sobreNome)
        {
            PrimeiroNome = primeiroNome;
            SobreNome = sobreNome;
        }

        public string PrimeiroNome { get; private set; }
        public string SobreNome { get; private set; }
    }
}