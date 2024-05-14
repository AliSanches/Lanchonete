using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLanchonete
{
    public partial class FormCadPedido : Form
    {
        public FormCadPedido()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente();
            string cpf = txtCpf.Text;

            ClienteDAO dao = new ClienteDAO();

            if(cpf.Length == 14)
            {
                obj = dao.BuscarPorCPF(txtCpf.Text);
                txtNome.Text = obj.nomeCompleto;
            }
            else
            {
                MessageBox.Show("INFORME UM CPF VALIDO!");
            }
        }
    }
}
