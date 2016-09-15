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
    public class CompraTest
    {
        private int _idUsuario = 1;

        private readonly CompraApplication _compraApplication;
        private readonly ICompraRepository _compraRepository;

        public CompraTest(CompraApplication compraApplication, ICompraRepository iCompraRepository)
        {
            _compraApplication = compraApplication;
            _compraRepository = iCompraRepository;
        }


        [TestMethod]
        public void CategoriaTest_Testa_Todas_Compras_Nao_Vazias()
        {
            var retorno = _compraRepository.RetornarTodosComprasPorUsuario(_idUsuario).ToList();
            Assert.IsNotNull(retorno);
        }


        [TestMethod]
        public void SubCategoriaTest_Testa_Todas_Compras_Retorna_1_Registro()
        {
            List<Compra> result = _compraRepository.RetornarTodosComprasPorUsuario(_idUsuario).ToList();
            Assert.AreEqual(1, result.Count());
        }

       
    }
}
