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
    public partial class FormDelUsuario : Form
    {
        public FormDelUsuario(int codigo, string nome, string cpf, string acesso, string celular, string telefone, string email, string nomeLogin, string senha, string estado, string cidade, string bairro, string rua, int numero)
        {
            InitializeComponent();

            txtCodigo.Text = codigo.ToString();
            txtNome.Text = nome;
            txtCpf.Text = cpf;
            txtEmail.Text = email;
            txtUsuario.Text = nomeLogin;
            txtSenha.Text = senha;
            cbAcesso.Text = acesso;
            txtTelefone.Text = telefone;
            txtCelular.Text = celular;
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

        private void btAlterar_Click(object sender, EventArgs e)
        {
            //Objeto modelo
            Usuario obj = new Usuario();
            obj.codigo = int.Parse(txtCodigo.Text);

            //Objeto métodos
            UsuarioDAO dao = new UsuarioDAO();
            dao.ExcluirUsuario(obj);

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

        private void txtCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtEmail.Enabled = false;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            txtUsuario.Enabled = false;
        }

        private void txtCelular_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            txtCelular.Enabled = false;
        }

        private void txtTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            txtTelefone.Enabled = false;
        }

        private void txtSenha_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            txtSenha.Enabled = false;
        }

        private void cbAcesso_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbAcesso.Enabled = false;
        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbEstado.Enabled = false;
        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {
            txtCidade.Enabled = false;
        }

        private void txtNumero_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            txtNumero.Enabled = false;
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

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {
            txtTelefone.Enabled = false;
        }

        private void txtCelular_TextChanged(object sender, EventArgs e)
        {
            txtCelular.Enabled = false;
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            txtNumero.Enabled = false;
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            txtSenha.Enabled = false;
        }
    }
}
