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
    [RoutePrefix("api/categoria")]
    public class CategoriaController : ApiController
    {
        private readonly CategoriaApplication _categoriaApplication;
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaController(CategoriaApplication categoriaApplication, ICategoriaRepository iCategoriaRepository)
        {
            _categoriaApplication = categoriaApplication;
            _categoriaRepository = iCategoriaRepository;
        }

        [HttpGet]
        public IEnumerable<Categoria> RetornarTodasCategorias()
        {
            return _categoriaRepository.RetornarTodasCategorias();
        }
    }
}
