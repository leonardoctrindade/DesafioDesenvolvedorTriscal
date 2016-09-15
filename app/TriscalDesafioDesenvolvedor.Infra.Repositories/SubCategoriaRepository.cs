using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriscalDesafioDesenvolvedor.Domain.Entities;
using TriscalDesafioDesenvolvedor.Domain.Interfaces;

namespace TriscalDesafioDesenvolvedor.Infra.Repositories
{
    public class SubCategoiaRepository : RepositoryBase<SubCategoia>, ISubCategoiaRepository
    {
        public IEnumerable<SubCategoia> RetornaSubCategoiaPorCategoria(int id)
        {
            return Context.SubCategoias.Where(x => x.IdCategoria == id);
        }
    }
}
