using SistemaLanchonete.br.lanchonete.view;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaLanchonete
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Principal());
        }
    }
}
