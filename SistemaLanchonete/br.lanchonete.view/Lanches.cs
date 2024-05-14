using DataEdit;
using SistemaLanchonete.br.lanchonete.DAO;
using SistemaLanchonete;
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
    public partial class Lanches : Form
    {
        public Lanches()
        {
            InitializeComponent();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            CadLanche telaCadastro = new CadLanche();
            telaCadastro.Show();
        }

        private void Lanches_Load(object sender, EventArgs e)
        {
            //Propriedade de cor
            dgvExibir.AllowUserToAddRows = false;

            //modificando tabela
            DGVDestilo.Formato(dgvExibir, 1);
            dgvExibir.Columns["Alterar"].Width = 50;
            dgvExibir.Columns["Excluir"].Width = 50;

            LancheDAO dao = new LancheDAO();
            DataTable tabela = dao.ListarLanche();

            // Preencher os dados na DataGridView
            foreach (DataRow row in tabela.Rows)
            {
                // Adicionar uma nova linha à DataGridView
                DataGridViewRow dgvRow = new DataGridViewRow();

                // Adicionar células à linha
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["ID"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Nome"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Ingredientes"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Valor"] });

                // Adicionar a linha preenchida à DataGridView
                dgvExibir.Rows.Add(dgvRow);
            }
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            txtPesquisa.Text = "";
            dgvExibir.Rows.Clear();

            LancheDAO dao = new LancheDAO();

            DataTable tabela = dao.ListarLanche();

            // Preencher os dados na DataGridView
            foreach (DataRow row in tabela.Rows)
            {
                // Adicionar uma nova linha à DataGridView
                DataGridViewRow dgvRow = new DataGridViewRow();

                // Adicionar células à linha
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["ID"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Nome"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Ingredientes"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Valor"] });

                // Adicionar a linha preenchida à DataGridView
                dgvExibir.Rows.Add(dgvRow);
            }
        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtPesquisa.Text + "%";

            LancheDAO dao = new LancheDAO();
            DataTable tabela = dao.ListarLanchePorNome(nome);

            // Invocar o método de limpeza de linhas no thread da interface do usuário
            dgvExibir.Invoke(new MethodInvoker(delegate
            {
                // Limpar todas as linhas existentes no DataGridView
                dgvExibir.Rows.Clear();
            }));

            // Preencher os novos dados na DataGridView
            foreach (DataRow row in tabela.Rows)
            {
                // Adicionar uma nova linha à DataGridView
                DataGridViewRow dgvRow = new DataGridViewRow();

                // Adicionar células à linha
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["ID"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Nome"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Ingredientes"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Valor"] });

                // Adicionar a linha preenchida à DataGridView
                dgvExibir.Rows.Add(dgvRow);
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            string nome = txtPesquisa.Text;
            dgvExibir.Rows.Clear();

            LancheDAO dao = new LancheDAO();
            DataTable tabela = dao.BuscarLancheNome(nome);

            // Preencher os dados na DataGridView
            foreach (DataRow row in tabela.Rows)
            {
                // Adicionar uma nova linha à DataGridView
                DataGridViewRow dgvRow = new DataGridViewRow();

                // Adicionar células à linha
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["ID"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Nome"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Ingredientes"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Valor"] });

                // Adicionar a linha preenchida à DataGridView
                dgvExibir.Rows.Add(dgvRow);
            }
        }

        private void dgvExibir_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvExibir.Columns[e.ColumnIndex].Name == "Alterar")
            {
                string codigo = dgvExibir.Rows[e.RowIndex].Cells[0].Value.ToString();
                string nome = dgvExibir.Rows[e.RowIndex].Cells[1].Value.ToString();
                string descricao = dgvExibir.Rows[e.RowIndex].Cells[2].Value.ToString();
                string preco = dgvExibir.Rows[e.RowIndex].Cells[3].Value.ToString();

                Altlanche alteraIngrediente = new Altlanche(codigo, nome, descricao, preco);
                alteraIngrediente.Show();
            }
            else if (dgvExibir.Columns[e.ColumnIndex].Name == "Excluir")
            {
                string codigo = dgvExibir.Rows[e.RowIndex].Cells[0].Value.ToString();
                string nome = dgvExibir.Rows[e.RowIndex].Cells[1].Value.ToString();
                string descricao = dgvExibir.Rows[e.RowIndex].Cells[2].Value.ToString();
                string preco = dgvExibir.Rows[e.RowIndex].Cells[3].Value.ToString();

                DelLanche excluirIngrediente = new DelLanche(codigo, nome, descricao, preco);
                excluirIngrediente.Show();
            }
        }
    }
}
