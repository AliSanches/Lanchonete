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
    public partial class FormPedido : Form
    {
        public FormPedido()
        {
            InitializeComponent();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            FormCadPedido telaPedido = new FormCadPedido();
            telaPedido.Show();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            dgvExibir.Rows.Clear();

            DateTime dataInicio, dataFinal;

            dataInicio = Convert.ToDateTime(dtInicio.Value.ToString("yyyy-MM-dd"));
            dataFinal = Convert.ToDateTime(dtFinal.Value.ToString("yyyy-MM-dd"));

            VendaDAO dao = new VendaDAO();
            DataTable tabela = dao.ListarPorPeriodo(dataInicio, dataFinal);

            // Preencher os dados na DataGridView
            foreach (DataRow row in tabela.Rows)
            {
                // Adicionar uma nova linha à DataGridView
                DataGridViewRow dgvRow = new DataGridViewRow();

                // Adicionar células à linha
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["ID"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["DataVenda"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["idCliente"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["idLanche"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Total"] });

                // Adicionar a linha preenchida à DataGridView
                dgvExibir.Rows.Add(dgvRow);
            }
        }

        private void dtInicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FormPedido_Load(object sender, EventArgs e)
        {
            //Modificando tabela
            DGVDestilo.Formato(dgvExibir, 1);

            dgvExibir.AllowUserToAddRows = false;

            VendaDAO dao = new VendaDAO();

            DataTable tabela = dao.ListarVendas();

            // Preencher os dados na DataGridView
            foreach (DataRow row in tabela.Rows)
            {
                // Adicionar uma nova linha à DataGridView
                DataGridViewRow dgvRow = new DataGridViewRow();

                // Obter a data da venda do DataRow
                DateTime dataVenda = (DateTime)row["DataVenda"];

                // Converter a data para uma string formatada sem incluir as horas
                string dataVendaFormatada = dataVenda.ToString("yyyy-MM-dd");

                // Adicionar células à linha
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["ID"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = dataVendaFormatada });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["idCliente"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["idLanche"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Total"] });

                // Adicionar a linha preenchida à DataGridView
                dgvExibir.Rows.Add(dgvRow);
            }
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            dgvExibir.Rows.Clear();

            VendaDAO dao = new VendaDAO();
            DataTable tabela = dao.ListarVendas();

            // Preencher os dados na DataGridView
            foreach (DataRow row in tabela.Rows)
            {
                // Adicionar uma nova linha à DataGridView
                DataGridViewRow dgvRow = new DataGridViewRow();

                // Adicionar células à linha
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["ID"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["DataVenda"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["idCliente"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["idLanche"] });
                dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = row["Total"] });

                // Adicionar a linha preenchida à DataGridView
                dgvExibir.Rows.Add(dgvRow);
            }
        }

        private void dgvExibir_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvExibir_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idVenda = int.Parse(dgvExibir.CurrentRow.Cells[0].Value.ToString());

            FormDetalhesVenda telaDetalhesVenda = new FormDetalhesVenda(idVenda);

            //Formatar a data
            DateTime data = Convert.ToDateTime(dgvExibir.CurrentRow.Cells[1].Value.ToString());

            telaDetalhesVenda.txtCliente.Text = dgvExibir.CurrentRow.Cells[2].Value.ToString();
            telaDetalhesVenda.txtData.Text = data.ToString("dd-MM-yyyy");
            telaDetalhesVenda.txtTotal.Text = dgvExibir.CurrentRow.Cells[4].Value.ToString();

            telaDetalhesVenda.Show();
        }
    }
}
