using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entities
{
    public class Produto
    {
        public Produto(int codProduto)
        {
            CodProduto = codProduto;
        }

        public int CodProduto { get; set; }
    }
}
