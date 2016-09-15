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
    public class ProdutoMap : EntityTypeConfiguration<Produto>
    {
        public ProdutoMap()
        {
            HasKey(e => e.IdProduto);
            Property(e => e.IdProduto).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Nome).IsRequired().HasMaxLength(50);
            Property(x => x.Valor).IsRequired().HasPrecision(10, 2);
            Property(x => x.Descricao).IsRequired().HasMaxLength(250);
            Property(x => x.PathImagem).IsRequired().HasMaxLength(300);
            Property(x => x.IdCategoria).IsRequired();
            Property(x => x.IdSubCategoia).IsOptional();
            Property(x => x.QuantidadeProdutos).IsOptional();
        }
    }
}
