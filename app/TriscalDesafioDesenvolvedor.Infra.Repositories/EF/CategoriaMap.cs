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
    public class CategoriaMap : EntityTypeConfiguration<Categoria>
    {
        public CategoriaMap()
        {
            HasKey(e => e.IdCategoria);
            Property(e => e.IdCategoria).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Categoria1).IsRequired().HasMaxLength(50);
        }
    }
}
