using ContextoDePagamento.Shared.Commands;

namespace ContextoDePagamento.Shared.Handlers
{
    public interface IHandler<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}