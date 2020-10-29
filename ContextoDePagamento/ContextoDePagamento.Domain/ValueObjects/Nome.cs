using ContextoDePagamento.Shared.ValueObjects;
using Flunt.Validations;

namespace ContextoDePagamento.Domain.ValueObjects
{
    public class Nome : ValueObject
    {
        public Nome(string primeiroNome, string sobreNome)
        {
            PrimeiroNome = primeiroNome;
            SobreNome = sobreNome;

            AddNotifications(new Contract()
            .Requires()
            .HasMinLen(PrimeiroNome, 3, "Nome.PrimeiroNome", "Nome inválido")
            .HasMaxLen(SobreNome, 3, "Nome.SobreNome", "Nome inválido"));
        }

        public string PrimeiroNome { get; private set; }
        public string SobreNome { get; private set; }
    }
}