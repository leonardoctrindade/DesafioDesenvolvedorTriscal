using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TriscalDesafioDesenvolvedor.Application;
using TriscalDesafioDesenvolvedor.Domain.Entities;
using TriscalDesafioDesenvolvedor.Domain.Interfaces;

namespace TriscalDesafioDesenvolvedor.UI.Controllers
{
    [RoutePrefix("api/produto")]
    public class ProdutoController : ApiController
    {

         private readonly ProdutoApplication _produtoApplication;
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoController(ProdutoApplication produtoApplication, IProdutoRepository produtoRepository)
        {
            _produtoApplication = produtoApplication;
            _produtoRepository = produtoRepository;
        }

        [HttpGet]
        public IEnumerable<Produto> RetornarTodosProdutos()
        {
            return _produtoRepository.Get();
        }

        [HttpGet]
        public IEnumerable<Produto> RetornaProdutoPorCategoria(int id)
        {
            return _produtoRepository.RetonarPorCategoria(id);
        }

        [HttpGet]
        public IEnumerable<Produto> RetornaProdutoPorSubCategoia(int id)
        {
            return _produtoRepository.RetonarPorSubCategoia(id);
        }

    }
}
