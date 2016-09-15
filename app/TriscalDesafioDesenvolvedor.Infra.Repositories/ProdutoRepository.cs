using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriscalDesafioDesenvolvedor.Domain.Entities;
using TriscalDesafioDesenvolvedor.Domain.Interfaces;

namespace TriscalDesafioDesenvolvedor.Infra.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {

        public IEnumerable<Produto> RetonarPorCategoria(int id)
        {
            return Context.Produtos.Where(x => x.IdCategoria == id);
        }

        public IEnumerable<Produto> RetonarPorSubCategoia(int id)
        {
           return Context.Produtos.Where(x => x.IdSubCategoia == id);
        }


       
    }
}
