using System.Collections.Generic;

namespace ContextoDePagamento.Domain.Entidades
{
    public class Estudante
    {
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string Documento { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public List<Assinatura> Assinatura { get; set; }
    }
}