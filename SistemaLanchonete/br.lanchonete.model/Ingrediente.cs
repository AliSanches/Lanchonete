using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLanchonete
{
    public class Ingrediente
    {
        // Atributos com get e set
        public string codigo { get; set; }

        public string nome { get; set; }

        public string quantidade { get; set; }

        public double preco { get; set; }

        internal DataGridView ObterDataGridView()
        {
            throw new NotImplementedException();
        }
    }
}
