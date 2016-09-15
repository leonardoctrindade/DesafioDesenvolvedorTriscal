using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriscalDesafioDesenvolvedor.Domain.Entities;
using TriscalDesafioDesenvolvedor.Domain.Interfaces;

namespace TriscalDesafioDesenvolvedor.Application
{
    public class CompraApplication : ApplicationBase
    {
        private readonly ICompraRepository _compraRepository;

        public CompraApplication(ICompraRepository compraRepository)
        {
            _compraRepository = compraRepository;
        }

        public void Register(Compra compra)
        {
            BeginTransaction();

            _compraRepository.Add(compra);

            Commit();
        }
    }
}
