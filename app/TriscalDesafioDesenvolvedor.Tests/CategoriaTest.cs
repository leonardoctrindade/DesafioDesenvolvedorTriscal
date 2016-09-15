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
    public class CategoriaTest
    {


         private readonly CategoriaApplication _categoriaApplication;
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaTest(CategoriaApplication categoriaApplication, ICategoriaRepository iCategoriaRepository)
        {
            _categoriaApplication = categoriaApplication;
            _categoriaRepository = iCategoriaRepository;
        }

        [TestMethod]
        public void CategoriaTest_Testa_Todas_Categorias_Nao_Vazias()
        {
            var retorno = _categoriaRepository.RetornarTodasCategorias().ToList();
            Assert.IsNotNull(retorno);
        }


        [TestMethod]
        public void SubCategoriaTest_Testa_Todas_Categorias_Retorna_2_Registros()
        {
            List<Categoria> result = _categoriaRepository.RetornarTodasCategorias().ToList();
            Assert.AreEqual(2, result.Count());
        }

       
    }
}
