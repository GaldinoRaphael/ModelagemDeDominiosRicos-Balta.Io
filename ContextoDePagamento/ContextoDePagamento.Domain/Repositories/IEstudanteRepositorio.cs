using ContextoDePagamento.Domain.Entidades;

namespace ContextoDePagamento.Domain.Repositories
{
    public interface IEstudanteRepositorio
    {
        bool DocumentoExiste(string documento);
        bool EmailExiste(string email);
        void CriaAssinatura(Estudante estudante);

    }
}