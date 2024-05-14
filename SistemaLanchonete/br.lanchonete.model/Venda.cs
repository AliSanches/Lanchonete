using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLanchonete
{
    public class Venda
    {
        // Atributos com get e set
        public int codigo { get; set; }

        public DateTime dataVenda { get; set; }

        public int idCliente { get; set; }

        public int idLanche { get; set; }

        public decimal totalVenda { get; set; }
    }
}
