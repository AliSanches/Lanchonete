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
    public partial class CadLanche : Form
    {
        public CadLanche()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
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

            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtDescricao.Text) || string.IsNullOrEmpty(txtValor.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                LancheDAO dao = new LancheDAO();
                dao.CadastrarLanche(obj);

                this.Close();
            }
        }
    }
}
