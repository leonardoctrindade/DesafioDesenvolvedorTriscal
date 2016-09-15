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
    [RoutePrefix("api/subCategoia")]
    public class SubCategoiaController : ApiController
    {
        private readonly SubCategoiaApplication _SubCategoiaApplication;
        private readonly ISubCategoiaRepository _SubCategoiaRepository;

        public SubCategoiaController(SubCategoiaApplication SubCategoiaApplication, ISubCategoiaRepository iSubCategoiaRepository)
        {
            _SubCategoiaApplication = SubCategoiaApplication;
            _SubCategoiaRepository = iSubCategoiaRepository;
        }

        [HttpGet]
        public IEnumerable<SubCategoia> RetornaSubCategoiaPorCategoria(int id)
        {
            return _SubCategoiaRepository.RetornaSubCategoiaPorCategoria(id);
        }
    }
}
