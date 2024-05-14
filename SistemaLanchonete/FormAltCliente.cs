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
    public partial class FormAltCliente : Form
    {
        public FormAltCliente(int codigo, string nome, string cpf, string celular, string telefone, string estado, string cidade, string bairro, string rua, int numero)
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

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            //Objeto modelo
            Cliente obj = new Cliente();
            obj.codigo = int.Parse(txtCodigo.Text);
            obj.nomeCompleto = txtNome.Text;
            obj.cpf = txtCpf.Text;
            obj.telefone = txtTelefone.Text;
            obj.celular = txtCelular.Text;
            obj.estado = cbEstado.Text;
            obj.cidade = txtCidade.Text;
            obj.bairro = txtBairro.Text;
            obj.rua = txtRua.Text;
            obj.numero = int.Parse(txtNumero.Text);

            //Objeto métodos
            ClienteDAO dao = new ClienteDAO();

            // Verifica se os campos são válidos
            if (dao.CamposValidos(obj))
            {
                // Se os campos forem válidos, prossegue com o cadastro
                dao.AlterarCliente(obj);
            }
            else
            {
                // Se os campos não forem válidos, exibe uma mensagem de erro ou faz outra ação apropriada
                MessageBox.Show("Por favor, preencha todos os campos corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            txtCodigo.Enabled = false;
        }
    }
}
