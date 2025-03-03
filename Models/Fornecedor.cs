using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoPOO_BD.Models
{
    class Fornecedor
    {
        public int idFornecedor { get; set; }
        public string nomeFantasia { get; set; }
        public string razaoSocial { get; set; }
        public string cnpj { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
    }
}
