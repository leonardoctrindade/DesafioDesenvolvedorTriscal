using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriscalDesafioDesenvolvedor.Domain.Entities
{
    public class Compra
    {
        public int IdCompra { get; set; }
        public decimal ValorCompra { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DataCadastro { get; set; }
        public int IdTipoEntrega { get; set; }
        public DateTime DataEntrega { get; set; }
        public string Endereco { get; set; }
    }
}
