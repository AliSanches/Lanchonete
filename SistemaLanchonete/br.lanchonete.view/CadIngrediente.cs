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
    public partial class CadIngrediente : Form
    {
        public CadIngrediente()
        {
            InitializeComponent();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            //instancia minha classe modelo
            Ingrediente obj = new Ingrediente();
            obj.codigo = txtCodigo.Text;
            obj.nome = txtNome.Text;
            obj.quantidade= txtQuantidade.Text;

            double preco;
            if (!double.TryParse(txtValor.Text, out preco))
            {
                MessageBox.Show("Por favor, insira um valor válido para o preço.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Sai do método para evitar operações adicionais
            }

            obj.preco = preco;

            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtQuantidade.Text) || string.IsNullOrEmpty(txtValor.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                IngredienteDAO dao = new IngredienteDAO();
                dao.CadastrarIngrediente(obj);

                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
