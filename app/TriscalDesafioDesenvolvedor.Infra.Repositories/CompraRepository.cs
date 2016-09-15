using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriscalDesafioDesenvolvedor.Domain.Entities;
using TriscalDesafioDesenvolvedor.Domain.Interfaces;

namespace TriscalDesafioDesenvolvedor.Infra.Repositories
{
    public class CompraRepository : RepositoryBase<Compra>, ICompraRepository
    {
        public IEnumerable<Compra> RetornarTodosComprasPorUsuario(int id)
        {
            return Context.Compras.ToList();
        }

        
    }
}
