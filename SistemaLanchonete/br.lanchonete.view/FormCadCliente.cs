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
    public partial class FormCadCliente : Form
    {
        public FormCadCliente()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            //Objeto modelo
            Cliente obj = new Cliente();
            obj.nomeCompleto = txtNome.Text;
            obj.cpf = txtCpf.Text;
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
            ClienteDAO dao = new ClienteDAO();

            // Verifica se os campos são válidos
            if (dao.CamposValidos(obj))
            {
                // Se os campos forem válidos, prossegue com o cadastro
                dao.CadastrarCliente(obj);
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
