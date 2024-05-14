using DataEdit;
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
    public partial class FormDetalhesVenda : Form
    {
        int idVenda;

        public FormDetalhesVenda(int idVenda)
        {
            InitializeComponent();
            this.idVenda = idVenda;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDetalhesVenda_Load(object sender, EventArgs e)
        {
            //Modificando tabela
            DGVDestilo.Formato(dgvExibirDetalhes, 1);
            DGVDestilo.Formato(dgvExibirLanche, 1);

            ItensVendaLancheDAO daoLanche = new ItensVendaLancheDAO();

            DataTable tabelaLanche = daoLanche.ListarItemVendaLanche(idVenda);
            // Preencher os dados na DataGridView
            foreach (DataRow row in tabelaLanche.Rows)
            {
                // Adicionar uma nova linha à DataGridView
                DataGridViewRow dgvRow = new DataGridViewRow();

                // Adicionar células à linha
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["ID"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Lanche"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["QtdUtilizada"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["SubTotal"] });

                // Adicionar a linha preenchida à DataGridView
                dgvExibirLanche.Rows.Add(dgvRow);
            }


            ItensVendaDAO dao = new ItensVendaDAO();

            DataTable tabela = dao.ListarItemVenda(idVenda);
            // Preencher os dados na DataGridView
            foreach (DataRow row in tabela.Rows)
            {
                // Adicionar uma nova linha à DataGridView
                DataGridViewRow dgvRow = new DataGridViewRow();

                // Adicionar células à linha
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["ID"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Ingrediente"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["QtdUtilizada"] });

                // Adicionar a linha preenchida à DataGridView
                dgvExibirDetalhes.Rows.Add(dgvRow);
            }
        }
    }
}
