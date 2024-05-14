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
    public partial class FormCadUsuario : Form
    {
        public FormCadUsuario()
        {
            InitializeComponent();
        }

        private void txtSenha_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            //Objeto modelo
            Usuario obj = new Usuario();
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


            if (int.TryParse(txtCodigo.Text, out int codigo))
            {
                // A conversão foi bem-sucedida, você pode usar o valor de 'codigo' aqui
                obj.codigo = codigo;
            }
            else
            {
                // O campo está vazio ou não pôde ser convertido para um número inteiro
                MessageBox.Show("Por favor, insira um número válido no campo Código.");
            }

            if (int.TryParse(txtNumero.Text, out int numero))
            {
                // A conversão foi bem-sucedida, você pode usar o valor de 'codigo' aqui
                obj.numero = numero;
            }
            else
            {
                // O campo está vazio ou não pôde ser convertido para um número inteiro
                MessageBox.Show("Por favor, insira um número válido no campo Número.");
            }


            //Objeto métodos
            UsuarioDAO dao = new UsuarioDAO();

            // Verifica se os campos são válidos
            if (dao.CamposValidos(obj))
            {
                // Se os campos forem válidos, prossegue com o cadastro
                dao.CadastrarUsuario(obj);
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
