using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriscalDesafioDesenvolvedor.Domain.Entities;

namespace TriscalDesafioDesenvolvedor.Infra.Repositories.EF
{
    public class CompraMap : EntityTypeConfiguration<Compra>
    {
        public CompraMap()
        {
            HasKey(e => e.IdCompra);
            Property(e => e.IdCompra).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ValorCompra).IsRequired();
            Property(x => x.IdUsuario).IsRequired();
            Property(x => x.DataCadastro).IsRequired();
            Property(x => x.IdTipoEntrega).IsRequired();
            Property(x => x.DataEntrega).IsRequired();
            Property(x => x.Endereco).IsRequired().HasMaxLength(100);
        }
    }
}
