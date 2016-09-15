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
    [RoutePrefix("api/TipoEntrega")]
    public class TipoEntregaController : ApiController
    {
        private readonly TipoEntregaApplication _tipoEntregaApplication;
        private readonly ITipoEntregaRepository _tipoEntregaRepository;

        public TipoEntregaController(TipoEntregaApplication tipoEntregaApplication, ITipoEntregaRepository iTipoEntregaRepository)
        {
            _tipoEntregaApplication = tipoEntregaApplication;
           _tipoEntregaRepository = iTipoEntregaRepository;
        }

        [HttpGet]
        public IEnumerable<TipoEntrega> RetornarTodasTipoEntrega()
        {
            return _tipoEntregaRepository.RetornarTodasTipoEntrega();
        }
    }
}
