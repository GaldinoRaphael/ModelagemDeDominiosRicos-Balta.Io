namespace ContextoDePamento.Domain.Services
{
    public interface IEmailService
    {
        void Enviar(string to, string email, string assunto, string corpo);
    }
}