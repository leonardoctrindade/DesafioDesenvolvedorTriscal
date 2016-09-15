using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriscalDesafioDesenvolvedor.Domain.Entities;
using TriscalDesafioDesenvolvedor.Domain.Interfaces;

namespace TriscalDesafioDesenvolvedor.Application
{
    public class TipoEntregaApplication : ApplicationBase
    {
        private readonly ITipoEntregaRepository _tipoEntregaRepository;

        public TipoEntregaApplication(ITipoEntregaRepository tipoEntregaRepository)
        {
            _tipoEntregaRepository = tipoEntregaRepository;
        }

        public void Register(TipoEntrega tipoEntrega)
        {
            BeginTransaction();

            _tipoEntregaRepository.Add(tipoEntrega);

            Commit();
        }
    }
}
