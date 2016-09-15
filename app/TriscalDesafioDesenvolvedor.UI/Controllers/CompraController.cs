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
    [RoutePrefix("api/compra")]
    public class CompraController : ApiController
    {
        private readonly CompraApplication _compraApplication;
        private readonly ICompraRepository _compraRepository;

        public CompraController(CompraApplication compraApplication, ICompraRepository iCompraRepository)
        {
            _compraApplication = compraApplication;
            _compraRepository = iCompraRepository;
        }

        [HttpGet]
        public IEnumerable<Compra> RetornarTodosComprasPorUsuario(int id)
        {
            return _compraRepository.RetornarTodosComprasPorUsuario(id);
        }


    }
}
