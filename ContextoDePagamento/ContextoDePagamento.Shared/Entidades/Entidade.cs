using System;

namespace ContextoDePagamento.Shared.Entidades
{
    public abstract class Entidade
    {
        public Guid Id { get; private set; }

        protected Entidade()
        {
            Id = Guid.NewGuid();
        }
    }
}