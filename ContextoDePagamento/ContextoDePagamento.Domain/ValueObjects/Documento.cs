using ContextoDePagamento.Domain.Enums;
using ContextoDePagamento.Shared.ValueObjects;
using Flunt.Validations;

namespace ContextoDePagamento.Domain.ValueObjects
{
    public class Documento : ValueObject
    {
        public Documento(string numero, EDocumentoTipo tipo)
        {
            Numero = numero;
            Tipo = tipo;

            AddNotifications(new Contract()
            .Requires()
            .IsTrue(Validacao(), "Documento.Numero", "Documento Inválido"));
        }

        public string Numero { get; private set; }

        public EDocumentoTipo Tipo { get; private set; }

        private bool Validacao()
        {
            if (Tipo == EDocumentoTipo.cnpj && Numero.Length == 14)
                return true;

            if (Tipo == EDocumentoTipo.cpf && Numero.Length == 11)
                return true;

            return false;
        }
    }
}