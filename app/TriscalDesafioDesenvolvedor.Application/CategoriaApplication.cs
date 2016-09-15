using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriscalDesafioDesenvolvedor.Domain.Entities;
using TriscalDesafioDesenvolvedor.Domain.Interfaces;

namespace TriscalDesafioDesenvolvedor.Application
{
    public class CategoriaApplication : ApplicationBase
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaApplication(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public void Register(Categoria categoria)
        {
            BeginTransaction();

            _categoriaRepository.Add(categoria);

            Commit();
        }
    }
}
