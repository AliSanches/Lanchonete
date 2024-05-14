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
    public partial class FormDelCliente : Form
    {
        public FormDelCliente(int codigo, string nome, string cpf, string celular, string telefone, string estado, string cidade, string bairro, string rua, int numero)
        {
            InitializeComponent();

            txtCodigo.Text = codigo.ToString();
            txtNome.Text = nome;
            txtCpf.Text = cpf;
            txtCelular.Text = celular;
            txtTelefone.Text = telefone;
            cbEstado.Text = estado;
            txtCidade.Text = cidade;
            txtBairro.Text = bairro;
            txtRua.Text = rua;
            txtNumero.Text = numero.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            //Objeto modelo
            Cliente obj = new Cliente();
            obj.codigo = int.Parse(txtCodigo.Text);

            ClienteDAO dao = new ClienteDAO();
            dao.ExcluirCliente(obj);

            this.Close();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            txtCodigo.Enabled = false;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            txtNome.Enabled = false;
        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {
            txtCidade.Enabled = false;
        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {
            txtBairro.Enabled = false;
        }

        private void txtRua_TextChanged(object sender, EventArgs e)
        {
            txtRua.Enabled = false;
        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
            txtCpf.Enabled = false;
        }

        private void txtCelular_TextChanged(object sender, EventArgs e)
        {
            txtCelular.Enabled = false;
        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {
            txtTelefone.Enabled = false;
        }

        private void cbEstado_TextChanged(object sender, EventArgs e)
        {
            cbEstado.Enabled = false;
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            txtNumero.Enabled = false;
        }
    }
}
