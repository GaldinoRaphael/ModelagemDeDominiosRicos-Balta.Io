using ContextoDePagamento.Domain.Enums;
using ContextoDePagamento.Shared.ValueObjects;

namespace ContextoDePagamento.Domain.ValueObjects
{
    public class Documento
    {
        public Documento(string numero, EDocumentoTipo tipo)
        {
            Numero = numero;
            Tipo = tipo;
        }

        public string Numero { get; private set; }

        public EDocumentoTipo Tipo { get; private set; }
    }
}