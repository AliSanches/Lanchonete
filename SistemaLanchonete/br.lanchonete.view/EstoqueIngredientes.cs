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

namespace SistemaLanchonete.br.lanchonete.view
{
    public partial class EstoqueIngredientes : Form
    {
        public EstoqueIngredientes()
        {
            InitializeComponent();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            Ingrediente objIngrediente = new Ingrediente();

            objIngrediente.codigo = txtCodigo.Text;
            objIngrediente.nome = txtNome.Text;
            objIngrediente.quantidade = txtQuantidade.Text;

            int valor;
            if (!int.TryParse(txtValor.Text, out valor))
            {
                MessageBox.Show("Por favor, insira um valor válido para o preço.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Sai do método para evitar operações adicionais
            }

            objIngrediente.preco = valor;

            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtQuantidade.Text) || string.IsNullOrEmpty(txtValor.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Passando o objeto preenchido para classe que executa os métodos || dao(objeto de acesso a dados)
                IngredienteDAO dao = new IngredienteDAO();

                dao.CadastrarIngrediente(objIngrediente);

                txtCodigo.Text = "";
                txtNome.Text = "";
                txtQuantidade.Text = "";
                txtValor.Text = "";

                dgvExibir.DataSource = dao.ListarIngrediente();
            }
        }

        private void EstoqueIngredientes_Load(object sender, EventArgs e)
        {
            dgvExibir.DefaultCellStyle.ForeColor = Color.Black;

            IngredienteDAO dao = new IngredienteDAO();

            dgvExibir.DataSource = dao.ListarIngrediente();
        }

        private void dgvExibir_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigoAD.Text = dgvExibir.CurrentRow.Cells[0].Value.ToString();
            txtNomeAD.Text = dgvExibir.CurrentRow.Cells[1].Value.ToString();
            txtQuantidadeAD.Text = dgvExibir.CurrentRow.Cells[2].Value.ToString();
            txtValorAD.Text = dgvExibir.CurrentRow.Cells[3].Value.ToString();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            Ingrediente objIngrediente = new Ingrediente();

            objIngrediente.codigo = txtCodigoAD.Text;
            objIngrediente.nome = txtNomeAD.Text;
            objIngrediente.quantidade = txtQuantidadeAD.Text;

            int valor;
            if (!int.TryParse(txtValorAD.Text, out valor))
            {
                MessageBox.Show("Por favor, insira um valor válido para o preço.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Sai do método para evitar operações adicionais
            }

            objIngrediente.preco = valor;

            if (string.IsNullOrEmpty(txtNomeAD.Text) || string.IsNullOrEmpty(txtQuantidadeAD.Text) || string.IsNullOrEmpty(txtValorAD.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Passando o objeto preenchido para classe que executa os métodos || dao(objeto de acesso a dados)
                IngredienteDAO dao = new IngredienteDAO();

                dao.AlterarIngrediente(objIngrediente);

                txtCodigoAD.Text = "";
                txtNomeAD.Text = "";
                txtQuantidadeAD.Text = "";
                txtValorAD.Text = "";

                dgvExibir.DataSource = dao.ListarIngrediente();
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            Ingrediente objIngrediente = new Ingrediente();
            objIngrediente.codigo = txtCodigoAD.Text;

            IngredienteDAO dao = new IngredienteDAO();
            dao.ExcluirIngrediente(objIngrediente);

            txtCodigoAD.Text = "";
            txtNomeAD.Text = "";
            txtQuantidadeAD.Text = "";
            txtValorAD.Text = "";

            dgvExibir.DataSource = dao.ListarIngrediente();
        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtPesquisa.Text + "%";

            IngredienteDAO dao = new IngredienteDAO();
            dgvExibir.DataSource = dao.ListarIngredientePorNome(nome);
        }
    }
}
