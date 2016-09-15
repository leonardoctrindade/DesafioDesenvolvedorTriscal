using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriscalDesafioDesenvolvedor.Domain.Entities;

namespace TriscalDesafioDesenvolvedor.Infra.Repositories.EF
{
    public class ArquiteturaContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<TipoEntrega> TipoEntregas { get; set; }
        public DbSet<SubCategoia> SubCategoias { get; set; }
        public DbSet<Compra> Compras { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoriaMap());
            modelBuilder.Configurations.Add(new ProdutoMap());
            modelBuilder.Configurations.Add(new SubCategoiaMap());
            modelBuilder.Configurations.Add(new TipoEntregaMap());
            modelBuilder.Configurations.Add(new CompraMap());

            modelBuilder.Entity<Produto>().Ignore(s => s.Quantidade);

            modelBuilder.Entity<Compra>()
    .Property(f => f.DataCadastro)
    .HasColumnType("datetime2")
    .HasPrecision(0);

            modelBuilder.Entity<Compra>()
   .Property(f => f.DataEntrega)
   .HasColumnType("datetime2")
   .HasPrecision(0);
        }
    }
}
