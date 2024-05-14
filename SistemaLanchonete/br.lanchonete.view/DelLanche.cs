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
    public partial class DelLanche : Form
    {
        public DelLanche(string codigo, string nome, string descricao, string preco)
        {
            InitializeComponent();
            txtCodigo.Text = codigo;
            txtNome.Text = nome;
            txtDescricao.Text = descricao;
            txtValor.Text = preco;
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            Lanche obj = new Lanche();
            obj.codigo = txtCodigo.Text;

            LancheDAO dao = new LancheDAO();
            dao.ExcluirLanche(obj);

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

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            txtDescricao.Enabled = false;
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            txtValor.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
