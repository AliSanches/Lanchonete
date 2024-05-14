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
    public partial class Altlanche : Form
    {
        public Altlanche(string codigo, string nome, string descricao, string preco)
        {
            InitializeComponent();
            txtCodigo.Text = codigo;
            txtNome.Text = nome;
            txtDescricao.Text = descricao;
            txtValor.Text = preco;
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            //instancia minha classe modelo
            Lanche obj = new Lanche();
            obj.codigo = txtCodigo.Text;
            obj.nome = txtNome.Text;
            obj.ingrediente = txtDescricao.Text;

            double preco;
            if (!double.TryParse(txtValor.Text, out preco))
            {
                MessageBox.Show("Por favor, insira um valor válido para o preço.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Sai do método para evitar operações adicionais
            }

            obj.preco = preco;

            if (txtNome.Text == "" || txtDescricao.Text == "" || txtValor.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                LancheDAO dao = new LancheDAO();
                dao.AlterarLanche(obj);

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
    }
}
