using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoPOO_BD.Models
{
    class Produto
    {
        public int idProduto { get; set; }
        public string nomeProduto { get; set; }
        public string categoria { get; set; }
        public string descricao { get; set; }
        public double preco { get; set; }
        public string undProduto { get; set; }
        public Fornecedor _fornecedor { get; set; }


    }
}
