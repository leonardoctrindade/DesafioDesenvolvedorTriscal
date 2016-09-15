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
    public class TipoEntregaTest
    {


     private readonly TipoEntregaApplication _tipoEntregaApplication;
        private readonly ITipoEntregaRepository _tipoEntregaRepository;

        public TipoEntregaTest(TipoEntregaApplication tipoEntregaApplication, ITipoEntregaRepository iTipoEntregaRepository)
        {
            _tipoEntregaApplication = tipoEntregaApplication;
           _tipoEntregaRepository = iTipoEntregaRepository;
        }

        [TestMethod]
        public void CategoriaTest_Testa_Todas_TipoEntrega_Nao_Vazias()
        {
            var retorno = _tipoEntregaRepository.RetornarTodasTipoEntrega().ToList();
            Assert.IsNotNull(retorno);
        }


        [TestMethod]
        public void SubCategoriaTest_Testa_Todas_TipoEntrega_Retorna_2_Registros()
        {
            List<TipoEntrega> result = _tipoEntregaRepository.RetornarTodasTipoEntrega().ToList();
            Assert.AreEqual(2, result.Count());
        }

       
    }
}
