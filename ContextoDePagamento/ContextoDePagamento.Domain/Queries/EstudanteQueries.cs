using System;
using System.Linq.Expressions;
using ContextoDePagamento.Domain.Entidades;

namespace ContextoDePagamento.Domain.Queries
{
    public static class EstudanteQueries
    {
        public static Expression<Func<Estudante, bool>> GetEstudanteInfo(string documento)
        {
            return x => x.Documento.Numero == documento;
        }
    }
}