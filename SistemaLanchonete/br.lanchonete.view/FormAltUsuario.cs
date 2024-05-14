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
    public partial class FormAltUsuario : Form
    {
        public FormAltUsuario(int codigo, string nome, string cpf, string acesso, string celular, string telefone, string email, string nomeLogin, string senha, string estado, string cidade, string bairro, string rua, int numero)
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

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            txtCodigo.Enabled = false;
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            //Objeto modelo
            Usuario obj = new Usuario();
            obj.codigo = int.Parse(txtCodigo.Text);
            obj.nomeCompleto = txtNome.Text;
            obj.cpf = txtCpf.Text;
            obj.email = txtEmail.Text;
            obj.senha = txtSenha.Text;
            obj.nomeLogin = txtUsuario.Text;
            obj.acesso = cbAcesso.Text;
            obj.telefone = txtTelefone.Text;
            obj.celular = txtCelular.Text;
            obj.estado = cbEstado.Text;
            obj.cidade = txtCidade.Text;
            obj.bairro = txtBairro.Text;
            obj.rua = txtRua.Text;
            obj.numero = int.Parse(txtNumero.Text);

            //Objeto métodos
            UsuarioDAO dao = new UsuarioDAO();

            // Verifica se os campos são válidos
            if (dao.CamposValidos(obj))
            {
                // Se os campos forem válidos, prossegue com o cadastro
                dao.AlterarUsuario(obj);
            }
            else
            {
                // Se os campos não forem válidos, exibe uma mensagem de erro ou faz outra ação apropriada
                MessageBox.Show("Por favor, preencha todos os campos corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }
    }
}
