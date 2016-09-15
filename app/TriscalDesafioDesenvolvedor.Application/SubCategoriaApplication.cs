using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriscalDesafioDesenvolvedor.Domain.Entities;
using TriscalDesafioDesenvolvedor.Domain.Interfaces;

namespace TriscalDesafioDesenvolvedor.Application
{
    public class SubCategoiaApplication : ApplicationBase
    {
        private readonly ISubCategoiaRepository _SubCategoiaRepository;

        public SubCategoiaApplication(ISubCategoiaRepository SubCategoiaRepository)
        {
            _SubCategoiaRepository = SubCategoiaRepository;
        }

        public void Register(SubCategoia SubCategoia)
        {
            BeginTransaction();

            _SubCategoiaRepository.Add(SubCategoia);

            Commit();
        }
    }
}
