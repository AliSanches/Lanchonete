using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLanchonete
{
    public class ItensVendaLanche
    {
        // Atributos com get e set
        public int codigoItensVenda { get; set; }

        public int vendaCodigo { get; set; }

        public int codigoLanche { get; set; }

        public int quantidadeUtilizada { get; set; }

        public decimal subTotal { get; set; }
    }
}
