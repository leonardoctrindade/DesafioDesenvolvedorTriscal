using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriscalDesafioDesenvolvedor.Domain.Entities;

namespace TriscalDesafioDesenvolvedor.Domain.Interfaces
{
    public interface ICompraRepository : IRepositoryBase<Compra>
    {
        IEnumerable<Compra> RetornarTodosComprasPorUsuario(int id);
    }
}
