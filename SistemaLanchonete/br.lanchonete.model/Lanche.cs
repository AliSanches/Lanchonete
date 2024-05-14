using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaLanchonete.br.lanchonete.model
{
    public class Lanche
    {
        // Atributos com get e set
        public string codigo { get; set; }

        public string nome { get; set; }

        public string ingrediente { get; set; }

        public double preco { get; set; }
    }
}
