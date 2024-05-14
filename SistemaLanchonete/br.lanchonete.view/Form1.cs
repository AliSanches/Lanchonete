using SistemaLanchonete.br.lanchonete.DAO;
using SistemaLanchonete.br.lanchonete.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaLanchonete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            //Capturando os dados e passando para o objeto Lanche
            Lanche objLanche = new Lanche();

            objLanche.codigo = txtCodigo.Text;
            objLanche.nome = txtNomeLanche.Text;
            objLanche.ingrediente = txtIngredienteLanche.Text;

            int preco;
            if (!int.TryParse(txtPrecoLanche.Text, out preco))
            {
                MessageBox.Show("Por favor, insira um valor válido para o preço.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Sai do método para evitar operações adicionais
            }

            objLanche.preco = preco;

            if (string.IsNullOrEmpty(txtNomeLanche.Text) || string.IsNullOrEmpty(txtIngredienteLanche.Text) || string.IsNullOrEmpty(txtPrecoLanche.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Passando o objeto preenchido para classe que executa os métodos || dao(objeto de acesso a dados)
                LancheDAO dao = new LancheDAO();

                dao.CadastrarLanche(objLanche);

                txtCodigo.Text = "";
                txtNomeLanche.Text = "";
                txtIngredienteLanche.Text = "";
                txtPrecoLanche.Text = "";

                dgvExibir.DataSource = dao.ListarLanche();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvExibir.DefaultCellStyle.ForeColor = Color.Black;

            LancheDAO dao = new LancheDAO();

            dgvExibir.DataSource = dao.ListarLanche();
        }

        private void dgvExibir_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgvExibir.CurrentRow.Cells[0].Value.ToString();
            txtNomeLanche.Text = dgvExibir.CurrentRow.Cells[1].Value.ToString();
            txtIngredienteLanche.Text = dgvExibir.CurrentRow.Cells[2].Value.ToString();
            txtPrecoLanche.Text = dgvExibir.CurrentRow.Cells[3].Value.ToString();

            tabConsulta.SelectedTab = tbCadastroLanche;
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            Lanche objLanche = new Lanche();
            objLanche.codigo = txtCodigo.Text;

            LancheDAO dao = new LancheDAO();
            dao.ExcluirLanche(objLanche);

            txtCodigo.Text = "";
            txtNomeLanche.Text = "";
            txtIngredienteLanche.Text = "";
            txtPrecoLanche.Text = "";

            dgvExibir.DataSource = dao.ListarLanche();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            Lanche objLanche = new Lanche();

            objLanche.codigo = txtCodigo.Text;
            objLanche.nome = txtNomeLanche.Text;
            objLanche.ingrediente = txtIngredienteLanche.Text;

            int preco;
            if (!int.TryParse(txtPrecoLanche.Text, out preco))
            {
                MessageBox.Show("Por favor, insira um valor válido para o preço.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Sai do método para evitar operações adicionais
            }

            objLanche.preco = preco;

            if (string.IsNullOrEmpty(txtNomeLanche.Text) || string.IsNullOrEmpty(txtIngredienteLanche.Text) || string.IsNullOrEmpty(txtPrecoLanche.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Passando o objeto preenchido para classe que executa os métodos || dao(objeto de acesso a dados)
                LancheDAO dao = new LancheDAO();

                dao.AlterarLanche(objLanche);

                txtCodigo.Text = "";
                txtNomeLanche.Text = "";
                txtIngredienteLanche.Text = "";
                txtPrecoLanche.Text = "";

                dgvExibir.DataSource = dao.ListarLanche();
            }
        }

        private void txtConsultar_TextChanged(object sender, EventArgs e)
        {
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtConsultar.Text;

            LancheDAO dao = new LancheDAO();
            dgvExibir.DataSource = dao.BuscarLancheNome(nome);

            if(dgvExibir.Rows.Count == 0)
            {
                dgvExibir.DataSource = dao.BuscarLancheNome(nome);
            }
        }

        private void txtConsultar_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtConsultar.Text + "%";

            LancheDAO dao = new LancheDAO();
            dgvExibir.DataSource = dao.ListarLanchePorNome(nome);
        }

        private void dgvExibir_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
