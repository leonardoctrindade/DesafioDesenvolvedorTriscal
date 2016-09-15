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
    public class TipoEntregaMap : EntityTypeConfiguration<TipoEntrega>
    {
        public TipoEntregaMap()
        {
            HasKey(e => e.IdTipoEntrega);
            Property(e => e.IdTipoEntrega).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.TipoEntrega1).IsRequired().HasMaxLength(50);
        }
    }
}
