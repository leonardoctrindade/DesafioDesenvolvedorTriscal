using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriscalDesafioDesenvolvedor.Domain.Interfaces;
using TriscalDesafioDesenvolvedor.Infra.Repositories;
using TriscalDesafioDesenvolvedor.Infra.Repositories.EF;

namespace TriscalDesafioDesenvolvedor.Infra.IoC
{
    public class IoCModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            Bind<IProdutoRepository>().To<ProdutoRepository>();
            Bind<ISubCategoiaRepository>().To<SubCategoiaRepository>();
            Bind<ICategoriaRepository>().To<CategoriaRepository>();
            Bind<ITipoEntregaRepository>().To<TipoEntregaRepository>();
            Bind<ICompraRepository>().To<CompraRepository>();
            Bind<IUnitOfWork>().To<UnitOfWork>();
            Bind<ContextManager>().ToSelf();
        }
    }
}
