using ContextoDePagamento.Shared.ValueObjects;

namespace ContextoDePagamento.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public Email(string endereco)
        {
            Endereco = endereco;
        }

        public string Endereco { get; private set; }
    }
}