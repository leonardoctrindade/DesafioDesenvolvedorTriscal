using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using TriscalDesafioDesenvolvedor.Domain.Entities;

namespace TriscalDesafioDesenvolvedor.Domain.Interfaces
{
    public interface ITipoEntregaRepository : IRepositoryBase<TipoEntrega>
    {
        IEnumerable<TipoEntrega> RetornarTodasTipoEntrega();
       
    }
}
