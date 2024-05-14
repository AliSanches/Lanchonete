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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaLanchonete
{
    public partial class DelIngrediente : Form
    {
        public DelIngrediente(string codigo, string nome, string ingrediente, string preco)
        {
            InitializeComponent();

            txtCodigo.Text = codigo;
            txtNome.Text = nome;
            txtQuantidade.Text = ingrediente;
            txtValor.Text = preco;
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            Ingrediente obj = new Ingrediente();
            obj.codigo = txtCodigo.Text;

            IngredienteDAO dao = new IngredienteDAO();
            dao.ExcluirIngrediente(obj);

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

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            txtNome.Enabled = false;
        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            txtQuantidade.Enabled = false;
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            txtValor.Enabled = false;
        }
    }
}
