using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriscalDesafioDesenvolvedor.Domain.Entities
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public string Descricao { get; set; }
        public string PathImagem { get; set; }
        public int IdCategoria { get; set; }
        public int? IdSubCategoia { get; set; }
        public int? QuantidadeProdutos { get; set; }
        public int Quantidade { get; set; }

    }
}
