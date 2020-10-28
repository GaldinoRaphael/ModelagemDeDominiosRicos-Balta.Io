using System;
using Flunt.Notifications;

namespace ContextoDePagamento.Shared.Entidades
{
    public abstract class Entidade : Notifiable
    {
        public Guid Id { get; private set; }

        protected Entidade()
        {
            Id = Guid.NewGuid();
        }
    }
}