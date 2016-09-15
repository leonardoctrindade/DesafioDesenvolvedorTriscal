using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TriscalDesafioDesenvolvedor.Application;
using TriscalDesafioDesenvolvedor.Domain.Interfaces;
using TriscalDesafioDesenvolvedor.Domain.Entities;

namespace TriscalDesafioDesenvolvedor.Tests.Domain
{
    [TestClass]
    public class ProdutoTest
    {
        private int _idCategoria = 1;
        private int _idSubCategoria = 1;

        private readonly ProdutoApplication _produtoApplication;
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoTest(ProdutoApplication produtoApplication, IProdutoRepository produtoRepository)
        {
            _produtoApplication = produtoApplication;
            _produtoRepository = produtoRepository;
        }


        [TestMethod]
        public void CategoriaTest_Testa_Todos_Produtos_Categorias_Nao_Vazias()
        {
            var retorno = _produtoRepository.RetonarPorCategoria(_idCategoria).ToList();
            Assert.IsNotNull(retorno);
        }


        [TestMethod]
        public void SubCategoriaTest_Testa_Todos_Produtos_Categorias_Retorna_1_Registro()
        {
            List<Produto> result = _produtoRepository.RetonarPorCategoria(_idCategoria).ToList();
            Assert.AreEqual(1, result.Count());
        }

        [TestMethod]
        public void CategoriaTest_Testa_Todos_Produtos_SubCategoria_Nao_Vazias()
        {
            var retorno = _produtoRepository.RetonarPorSubCategoia(_idSubCategoria).ToList();
            Assert.IsNotNull(retorno);
        }


        [TestMethod]
        public void SubCategoriaTest_Testa_Todos_Produtos_SubCategoria_Retorna_1_Registro()
        {
            List<Produto> result = _produtoRepository.RetonarPorSubCategoia(_idSubCategoria).ToList();
            Assert.AreEqual(1, result.Count());
        }

    }
}
