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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaLanchonete
{
    public partial class FormCadPedido : Form
    {
        //Variaveis
        int quantidade;
        decimal preco;
        decimal subtotal, total;

        //Classe
        Cliente obj = new Cliente();

        //Classe
        Lanche objLanche = new Lanche();

        //Ingrediente
        Ingrediente objIngrediente = new Ingrediente();

        //CarrinhoLanche
        DataTable carrinhoLanche = new DataTable();

        //CarrinhoIngrediente
        DataTable carrinhoIngrediente = new DataTable();

        public FormCadPedido()
        {
            InitializeComponent();

            carrinhoLanche.Columns.Add("ID", typeof(int));
            carrinhoLanche.Columns.Add("Nome", typeof(string));
            carrinhoLanche.Columns.Add("Descricao", typeof(string));
            carrinhoLanche.Columns.Add("Valor", typeof(decimal));
            carrinhoLanche.Columns.Add("Qtd", typeof(int));
            carrinhoLanche.Columns.Add("SubTotal", typeof(decimal));

            carrinhoIngrediente.Columns.Add("ID", typeof(int));
            carrinhoIngrediente.Columns.Add("Nome", typeof(string));
            carrinhoIngrediente.Columns.Add("Qtd", typeof(string));

            //Removendo linha extra
            dgvCarrinhoLanche.AllowUserToAddRows = false;
            dgvCarrinhoIngrediente.AllowUserToAddRows = false;

            //Atribuindo ao meu dataGridView uma Fonte de Dados
            dgvCarrinhoLanche.DataSource = carrinhoLanche;
            dgvCarrinhoIngrediente.DataSource = carrinhoIngrediente;

        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            string cpf = txtCpf.Text;

            ClienteDAO dao = new ClienteDAO();

            if (cpf.Length == 14)
            {
                obj = dao.BuscarPorCPF(txtCpf.Text);

                if (obj != null)
                {
                    // Se o objeto for encontrado, atualize o campo de texto com o nome completo
                    txtNome.Text = obj.nomeCompleto;
                }
                else
                {
                    // Se o objeto não for encontrado, limpe o campo de CPF e dê foco a ele novamente
                    txtCpf.Clear();
                    txtCpf.Focus();
                }
            }
            else
            {
                MessageBox.Show("Digite um CPF valido!");
                txtCpf.Focus();
            }
        }

        private void btBuscarLanche_Click(object sender, EventArgs e)
        {

            LancheDAO dao = new LancheDAO();

            if(objLanche != null)
            {
                objLanche = dao.RetornaLanchePorNome(cbLanche.Text);

                if (cbLanche.Text != "")
                {
                    cbLanche.Text = objLanche.nome;
                    txtValorLanche.Text = objLanche.preco.ToString();
                    txtDescricaoLanche.Text = objLanche.ingrediente;
                }
                else
                {
                    MessageBox.Show("Digite ou selecione um Lanche!");
                    cbLanche.Focus();
                }
            }
            else
            {
                MessageBox.Show("Digite ou selecione um Lanche!");
                cbLanche.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if(dgvCarrinhoLanche.CurrentRow != null && dgvCarrinhoLanche.CurrentRow.Cells[5].Value != null && !string.IsNullOrWhiteSpace(dgvCarrinhoLanche.CurrentRow.Cells[5].Value.ToString()))
            {
                decimal subProduto = decimal.Parse(dgvCarrinhoLanche.CurrentRow.Cells[5].Value.ToString());

                int indice = dgvCarrinhoLanche.CurrentCell.RowIndex;

                DataRow linha = carrinhoLanche.Rows[indice];

                carrinhoLanche.Rows.Remove(linha);
                carrinhoLanche.AcceptChanges();

                total -= subProduto;

                txtTotal.Text = total.ToString();

                cbLanche.Text = "";
                txtValorLanche.Text = "";
                txtDescricaoLanche.Text = "";
                txtQuantidadeLanche.Text = "";  
            }
            else
            {
                MessageBox.Show("Nenhum Lanche Selecionado");
            }
        }

        private void btAdicionarIngrediente_Click(object sender, EventArgs e)
        {

            try
            {
                //Variaveis com valores
                quantidade = int.Parse(txtQuantidadeIngrediente.Text);

                //Verificação se o campo quantidade esta vazio
                if (txtQuantidadeIngrediente.Text == "")
                {
                    MessageBox.Show("Por favor preencha o campo de Quantidade");
                    txtQuantidadeIngrediente.Focus();
                }
                else
                {
                    //Adicionando campos a tabela carrinho
                    carrinhoIngrediente.Rows.Add(int.Parse(cbIngrediente.SelectedValue.ToString()), cbIngrediente.Text, txtQuantidadeIngrediente.Text);

                    cbIngrediente.Text = "";
                    txtQuantidadeIngrediente.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Preencha todos os campos!");
            }

        }

        private void btBuscarIngrediente_Click(object sender, EventArgs e)
        {
            Ingrediente obj = new Ingrediente();

            IngredienteDAO dao = new IngredienteDAO();

            if(obj != null )
            {
                obj = dao.RetornaIngredientePorNome(cbIngrediente.Text);

                if(cbIngrediente.Text != "")
                {
                    cbIngrediente.Text = obj.nome.ToString();
                }
                else
                {
                    MessageBox.Show("Digite um ingrediente");
                    cbIngrediente.Focus();
                }
            }
            else
            {
                MessageBox.Show("Insira um ingrediente valido!");                          
            }
        }

        private void btRemoverIngrediente_Click(object sender, EventArgs e)
        {
            if(dgvCarrinhoIngrediente.CurrentRow != null)
            {
                int indice = dgvCarrinhoIngrediente.CurrentCell.RowIndex;

                DataRow linha = carrinhoIngrediente.Rows[indice];

                carrinhoIngrediente.Rows.Remove(linha);
                carrinhoIngrediente.AcceptChanges();

                cbIngrediente.Text = "";
                txtQuantidadeIngrediente.Text = "";
            }
            else
            {
                MessageBox.Show("Nenhum Ingrediente Selecionado!");
            }
        }

        private void btPagamento_Click(object sender, EventArgs e)
        {
            DateTime dataAtual = DateTime.Parse(txtData.Text);
            FormPagamento telaPagamento = new FormPagamento(this, obj, objLanche, objIngrediente,  carrinhoLanche, carrinhoIngrediente, dataAtual);

            telaPagamento.txtTotal.Text = total.ToString();
            telaPagamento.ShowDialog();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCadPedido_Load(object sender, EventArgs e)
        {

            //Pegando a data atual
            txtData.Text = DateTime.Now.ToShortDateString();

            IngredienteDAO dao = new IngredienteDAO();
            dao.PreencherComboBox(cbIngrediente);

            LancheDAO daoLanche = new LancheDAO();
            daoLanche.PreencherComboBox(cbLanche);

            txtValorLanche.Text = "";
            txtDescricaoLanche.Text = "";
        }

        private void txtCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cbIngrediente_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cbLanche_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLanche.SelectedItem != null && cbLanche.SelectedItem is DataRowView)
            {
                DataRowView selectedRow = cbLanche.SelectedItem as DataRowView;

                // Obter o preço do item selecionado
                decimal preco = Convert.ToDecimal(selectedRow["preco_lanche"]);
                string descricao = Convert.ToString(selectedRow["descricao_lanche"]);

                // Exibir o preço no TextBox
                txtValorLanche.Text = preco.ToString(); // Formatar o preço como moeda
                txtDescricaoLanche.Text = descricao;
            }
            else
            {
                txtValorLanche.Text = string.Empty;
            }
        }

        private void dgvCarrinhoLanche_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegando dados das linhas do datagridview
            cbLanche.Text = dgvCarrinhoLanche.CurrentRow.Cells[1].Value.ToString();
            txtDescricaoLanche.Text = dgvCarrinhoLanche.CurrentRow.Cells[2].Value.ToString();
            txtValorLanche.Text = dgvCarrinhoLanche.CurrentRow.Cells[3].Value.ToString();
            txtQuantidadeLanche.Text = dgvCarrinhoLanche.CurrentRow.Cells[4].Value.ToString();
        }

        private void dgvCarrinhoIngrediente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegando dados das linhas do datagridview
            cbIngrediente.Text = dgvCarrinhoIngrediente.CurrentRow.Cells[1].Value.ToString();
            txtQuantidadeIngrediente.Text = dgvCarrinhoIngrediente.CurrentRow.Cells[2].Value.ToString();
        }

        private void btAdicionarLanche_Click(object sender, EventArgs e)
        {
            try
            {
                //Variaveis com valores
                quantidade = int.Parse(txtQuantidadeLanche.Text);
                preco = decimal.Parse(txtValorLanche.Text);

                //Operação para somar
                subtotal = quantidade * preco;

                //Atribui o valor de subtotal ao total
                total += subtotal;

                //Convertendo para exibir no campo total
                txtTotal.Text = total.ToString();

                //Verificação se o campo quantidade esta vazio
                if (txtQuantidadeLanche.Text != "")
                {
                    //Adicionando campos a tabela carrinho
                    carrinhoLanche.Rows.Add(int.Parse(cbLanche.SelectedValue.ToString()), cbLanche.Text, txtDescricaoLanche.Text, preco, quantidade, subtotal);

                    cbLanche.Text = "";
                    txtDescricaoLanche.Text = "";
                    txtValorLanche.Text = "";
                    txtQuantidadeLanche.Text = "";
                }
                else
                {
                    MessageBox.Show("Por favor preencha o campo de quantidade");
                    txtQuantidadeLanche.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Preencha todos os campos");
            }
        }
    }
}
