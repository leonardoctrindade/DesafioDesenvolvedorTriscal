using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriscalDesafioDesenvolvedor.Domain.Entities;
using TriscalDesafioDesenvolvedor.Domain.Interfaces;

namespace TriscalDesafioDesenvolvedor.Infra.Repositories
{
    public class TipoEntregaRepository : RepositoryBase<TipoEntrega>, ITipoEntregaRepository
    {
        public IEnumerable<TipoEntrega> RetornarTodasTipoEntrega()
        {
            return Context.TipoEntregas.ToList();
        }

        
    }
}
