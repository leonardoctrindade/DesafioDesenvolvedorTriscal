using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriscalDesafioDesenvolvedor.Domain.Entities;
using TriscalDesafioDesenvolvedor.Application;
using TriscalDesafioDesenvolvedor.Domain.Interfaces;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TriscalDesafioDesenvolvedor.Tests.Domain
{
    [TestClass]
    public class SubCategoriaTest
    {

        private readonly SubCategoiaApplication _subCategoriaApplication;
        private readonly ISubCategoiaRepository _subCategoriaRepository;

        public SubCategoriaTest(SubCategoiaApplication subCategoriaApplication, ISubCategoiaRepository iSubCategoriaRepository)
        {
            _subCategoriaApplication = subCategoriaApplication;
            _subCategoriaRepository = iSubCategoriaRepository;
        }

        private int _idUsuario = 1;

        [TestMethod]
        public void SubCategoriaTest_Testa_Todas_SubCategorias_Nao_Vazias()
        {
            List<SubCategoia> result = _subCategoriaRepository.RetornaSubCategoiaPorCategoria(_idUsuario).ToList();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void SubCategoriaTest_Testa_Todas_SubCategorias_Retorna_1_Registro()
        {
            List<SubCategoia> result = _subCategoriaRepository.RetornaSubCategoiaPorCategoria(_idUsuario).ToList();
            Assert.AreEqual(1, result.Count());
        }





    }
}
