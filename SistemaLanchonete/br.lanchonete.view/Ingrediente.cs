using DataEdit;
using SistemaLanchonete.br.lanchonete.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLanchonete
{
    public partial class teste : Form
    {
        public teste()
        {
            InitializeComponent();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            CadIngrediente forms = new CadIngrediente();
            forms.Show();
        }

        private void btAtualizar_Click_1(object sender, EventArgs e)
        {
            txtPesquisa.Text = "";
            dgvExibir.Rows.Clear();

            IngredienteDAO dao = new IngredienteDAO();

            DataTable tabela = dao.ListarIngrediente();

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

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPesquisa_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtPesquisa.Text + "%";

            IngredienteDAO dao = new IngredienteDAO();
            DataTable tabela = dao.ListarIngredientePorNome(nome);

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

        private void Ingrediente_Load_1(object sender, EventArgs e)
        {
            //Propriedade de cor
            dgvExibir.AllowUserToAddRows = false;

            //Modificando tabela
            DGVDestilo.Formato(dgvExibir, 1);
            dgvExibir.Columns["Alterar"].Width= 50;
            dgvExibir.Columns["Excluir"].Width = 50;

            IngredienteDAO dao = new IngredienteDAO();
            DataTable tabela = dao.ListarIngrediente();

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
                string ingrediente = dgvExibir.Rows[e.RowIndex].Cells[2].Value.ToString();
                string preco = dgvExibir.Rows[e.RowIndex].Cells[3].Value.ToString();

                AltIntegrediente alteraIngrediente = new AltIntegrediente(codigo, nome, ingrediente, preco);
                alteraIngrediente.Show();
            }
            else if (dgvExibir.Columns[e.ColumnIndex].Name == "Excluir")
            {
                string codigo = dgvExibir.Rows[e.RowIndex].Cells[0].Value.ToString();
                string nome = dgvExibir.Rows[e.RowIndex].Cells[1].Value.ToString();
                string ingrediente = dgvExibir.Rows[e.RowIndex].Cells[2].Value.ToString();
                string preco = dgvExibir.Rows[e.RowIndex].Cells[3].Value.ToString();

                DelIngrediente excluirIngrediente = new DelIngrediente(codigo, nome, ingrediente, preco);
                excluirIngrediente.Show();
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            string nome = txtPesquisa.Text;
            dgvExibir.Rows.Clear();

            IngredienteDAO dao = new IngredienteDAO();
            DataTable tabela = dao.BuscarIngredienteNome(nome);

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

        private void lbAltera_Click(object sender, EventArgs e)
        {

        }
    }
}
