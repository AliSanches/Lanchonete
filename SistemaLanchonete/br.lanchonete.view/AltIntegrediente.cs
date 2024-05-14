using SistemaLanchonete.br.lanchonete.DAO;
using SistemaLanchonete.br.lanchonete.model;
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
    public partial class AltIntegrediente : Form
    {
        public AltIntegrediente(string codigo, string nome, string ingrediente, string preco)
        {
            InitializeComponent();

            txtCodigo.Text = codigo;
            txtNome.Text = nome;
            txtQuantidade.Text = ingrediente;
            txtValor.Text = preco;
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            //instancia minha classe modelo
            Ingrediente obj = new Ingrediente();
            obj.codigo = txtCodigo.Text;
            obj.nome = txtNome.Text;
            obj.quantidade = txtQuantidade.Text;

            double preco;
            if (!double.TryParse(txtValor.Text, out preco))
            {
                MessageBox.Show("Por favor, insira um valor válido para o preço.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Sai do método para evitar operações adicionais
            }

            obj.preco = preco;

            if (txtNome.Text == "" || txtQuantidade.Text == "" || txtValor.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                IngredienteDAO dao = new IngredienteDAO();
                dao.AlterarIngrediente(obj);

                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            txtCodigo.Enabled = false;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
