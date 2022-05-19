using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entities
{
    public class Estoque
    {
        public Estoque(Produto produto, int quantidadeMinima, int quantidadeAtual)
        {
            Produto = produto;
            QuantidadeMinima = quantidadeMinima;
            QuantidadeAtual = quantidadeAtual;
        }

        public Produto Produto { get; set; }
        public int QuantidadeMinima { get; set; }
        public int QuantidadeAtual { get; set; }

    }
}
