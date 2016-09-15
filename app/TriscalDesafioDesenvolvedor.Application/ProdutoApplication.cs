using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriscalDesafioDesenvolvedor.Domain.Entities;
using TriscalDesafioDesenvolvedor.Domain.Interfaces;

namespace TriscalDesafioDesenvolvedor.Application
{
    public class ProdutoApplication : ApplicationBase
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoApplication(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public void Register(Produto produto)
        {
            BeginTransaction();

            _produtoRepository.Add(produto);

            Commit();
        }
    }
}
