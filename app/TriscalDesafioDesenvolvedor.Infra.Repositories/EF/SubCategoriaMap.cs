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
    public class SubCategoiaMap : EntityTypeConfiguration<SubCategoia>
    {
        public SubCategoiaMap()
        {
            HasKey(e => e.IdSubCategoia);
            Property(e => e.IdSubCategoia).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.SubCategoia1).IsRequired().HasMaxLength(50);
            Property(x => x.IdCategoria).IsRequired();
        }
    }
}
