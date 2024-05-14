using DataEdit;
using SistemaLanchonete.br.lanchonete.DAO;
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
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            //Propriedade de cor
            dgvExibir.AllowUserToAddRows = false;

            //modificando tabela
            DGVDestilo.Formato(dgvExibir, 1);
            dgvExibir.Columns["Alterar"].Width = 50;
            dgvExibir.Columns["Excluir"].Width = 50;

            UsuarioDAO dao = new UsuarioDAO();
            DataTable tabela = dao.ListarUsuario();

            // Preencher os dados na DataGridView
            foreach (DataRow row in tabela.Rows)
            {
                // Adicionar uma nova linha à DataGridView
                DataGridViewRow dgvRow = new DataGridViewRow();

                // Adicionar células à linha
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["ID"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Nome"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Cpf"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Acesso"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Contato"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Telefone"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Email"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Login"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Senha"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["UF"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Cidade"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Bairro"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Rua"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Numero"] });


                // Adicionar a linha preenchida à DataGridView
                dgvExibir.Rows.Add(dgvRow);
            }
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            FormCadUsuario telaCadastro = new FormCadUsuario();
            telaCadastro.Show();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            txtPesquisa.Text = "";
            dgvExibir.Rows.Clear();

            UsuarioDAO dao = new UsuarioDAO();

            DataTable tabela = dao.ListarUsuario();

            // Preencher os dados na DataGridView
            foreach (DataRow row in tabela.Rows)
            {
                // Adicionar uma nova linha à DataGridView
                DataGridViewRow dgvRow = new DataGridViewRow();

                // Adicionar células à linha
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["ID"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Nome"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Cpf"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Acesso"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Contato"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Telefone"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Email"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Login"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Senha"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["UF"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Cidade"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Bairro"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Rua"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Numero"] });

                // Adicionar a linha preenchida à DataGridView
                dgvExibir.Rows.Add(dgvRow);
            }
        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtPesquisa.Text + "%";

            UsuarioDAO dao = new UsuarioDAO();
            DataTable tabela = dao.ListarUsuarioPorNome(nome);

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
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Cpf"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Acesso"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Contato"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Telefone"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Email"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Login"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Senha"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["UF"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Cidade"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Bairro"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Rua"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Numero"] });

                // Adicionar a linha preenchida à DataGridView
                dgvExibir.Rows.Add(dgvRow);
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            string nome = txtPesquisa.Text;
            dgvExibir.Rows.Clear();

            UsuarioDAO dao = new UsuarioDAO();
            DataTable tabela = dao.BuscarUsuarioNome(nome);

            // Preencher os dados na DataGridView
            foreach (DataRow row in tabela.Rows)
            {
                // Adicionar uma nova linha à DataGridView
                DataGridViewRow dgvRow = new DataGridViewRow();

                // Adicionar células à linha
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["ID"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Nome"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Cpf"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Acesso"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Contato"] });

                // Adicionar a linha preenchida à DataGridView
                dgvExibir.Rows.Add(dgvRow);
            }
        }

        private void dgvExibir_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvExibir.Columns[e.ColumnIndex].Name == "Alterar")
            {
                int codigo = int.Parse(dgvExibir.Rows[e.RowIndex].Cells[0].Value.ToString());
                string nome = dgvExibir.Rows[e.RowIndex].Cells[1].Value.ToString();
                string cpf = dgvExibir.Rows[e.RowIndex].Cells[2].Value.ToString();
                string acesso = dgvExibir.Rows[e.RowIndex].Cells[3].Value.ToString();
                string celular = dgvExibir.Rows[e.RowIndex].Cells[4].Value.ToString();
                string telefone = dgvExibir.Rows[e.RowIndex].Cells[5].Value.ToString();
                string email = dgvExibir.Rows[e.RowIndex].Cells[6].Value.ToString();
                string nomeLogin = dgvExibir.Rows[e.RowIndex].Cells[7].Value.ToString();
                string senha = dgvExibir.Rows[e.RowIndex].Cells[8].Value.ToString();
                string estado = dgvExibir.Rows[e.RowIndex].Cells[9].Value.ToString();
                string cidade = dgvExibir.Rows[e.RowIndex].Cells[10].Value.ToString();
                string bairro = dgvExibir.Rows[e.RowIndex].Cells[11].Value.ToString();
                string rua = dgvExibir.Rows[e.RowIndex].Cells[12].Value.ToString();
                int numero = int.Parse(dgvExibir.Rows[e.RowIndex].Cells[13].Value.ToString());

                FormAltUsuario alteraUsuario = new FormAltUsuario(codigo, nome, cpf, acesso, celular, telefone, email, nomeLogin, senha, estado, cidade, bairro, rua, numero);
                alteraUsuario.Show();
            }
            else if (dgvExibir.Columns[e.ColumnIndex].Name == "Excluir")
            {
                int codigo = int.Parse(dgvExibir.Rows[e.RowIndex].Cells[0].Value.ToString());
                string nome = dgvExibir.Rows[e.RowIndex].Cells[1].Value.ToString();
                string cpf = dgvExibir.Rows[e.RowIndex].Cells[2].Value.ToString();
                string acesso = dgvExibir.Rows[e.RowIndex].Cells[3].Value.ToString();
                string celular = dgvExibir.Rows[e.RowIndex].Cells[4].Value.ToString();
                string telefone = dgvExibir.Rows[e.RowIndex].Cells[5].Value.ToString();
                string email = dgvExibir.Rows[e.RowIndex].Cells[6].Value.ToString();
                string nomeLogin = dgvExibir.Rows[e.RowIndex].Cells[7].Value.ToString();
                string senha = dgvExibir.Rows[e.RowIndex].Cells[8].Value.ToString();
                string estado = dgvExibir.Rows[e.RowIndex].Cells[9].Value.ToString();
                string cidade = dgvExibir.Rows[e.RowIndex].Cells[10].Value.ToString();
                string bairro = dgvExibir.Rows[e.RowIndex].Cells[11].Value.ToString();
                string rua = dgvExibir.Rows[e.RowIndex].Cells[12].Value.ToString();
                int numero = int.Parse(dgvExibir.Rows[e.RowIndex].Cells[13].Value.ToString());

                FormDelUsuario ExcluiUsuario = new FormDelUsuario(codigo, nome, cpf, acesso, celular, telefone, email, nomeLogin, senha, estado, cidade, bairro, rua, numero);
                ExcluiUsuario.Show();
            }
        }

        private void dgvExibir_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verifica se a célula pertence à coluna de senha e se o valor da célula não é nulo
            if (dgvExibir.Columns[e.ColumnIndex].Name == "Senha" && e.Value != null)
            {
                // Define o valor da célula como uma string de asteriscos com o mesmo comprimento da senha
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }
    }
}
