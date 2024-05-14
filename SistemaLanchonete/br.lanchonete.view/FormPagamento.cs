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
    public partial class FormPagamento : Form
    {
        private FormCadPedido formPedido;
        Cliente cliente = new Cliente();
        Lanche lanche = new Lanche();
        Ingrediente ingrediente = new Ingrediente();
        DataTable carrinhoLanche = new DataTable();
        DataTable carrinhoIngrediente = new DataTable();
        DateTime dataAtual;

        public FormPagamento(FormCadPedido formPedido, Cliente cliente, Lanche lanche, Ingrediente ingrediente, DataTable carrinhoLanche, DataTable carrinhoIngrediente, DateTime dataAtual)
        {
            InitializeComponent();

            this.formPedido = formPedido;
            this.cliente = cliente;
            this.lanche = lanche;
            this.ingrediente = ingrediente;
            this.carrinhoLanche = carrinhoLanche;
            this.carrinhoIngrediente = carrinhoIngrediente;
            this.dataAtual = dataAtual;
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAdicionarLanche_Click(object sender, EventArgs e)
        {
            try
            {
                //Variaveis para manipulacao de valores
                decimal valorDinheiro, valorTroco, valorPago, total;

                IngredienteDAO daoIngrediente = new IngredienteDAO();
                int quantidade_estoque, quantidade_comprada, quantidade_atualizada;

                //Armazenando o valor das txtBox nas variaveis
                valorDinheiro = decimal.Parse(txtDinheiro.Text);
                total = decimal.Parse(txtTotal.Text);

                //Pix + Dinheiro + Cartão
                valorPago = valorDinheiro;

                //Verificacao
                if(valorPago < total)
                {
                    MessageBox.Show("VALOR INSERIDO MENOR QUE O VALOR TOTAL", "INCORRETO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //Calcula o troco
                    valorTroco = valorPago - total;

                    Venda obj = new Venda();

                    if (carrinhoLanche.Rows.Count > 0)
                    {
                        // Obtém a primeira linha do DataTable
                        DataRow row = carrinhoLanche.Rows[0];

                        obj.dataVenda = dataAtual;
                        obj.idCliente = cliente.codigo;
                        obj.idLanche = int.Parse(row[0].ToString());
                        obj.totalVenda = total;
                    }

                    VendaDAO daoVenda = new VendaDAO();

                    //Exibe o valor do troco na txtBox
                    txtTrocado.Text = valorTroco.ToString();

                    daoVenda.CadastrarVenda(obj);

                    foreach(DataRow linhaLanche in carrinhoLanche.Rows)
                    {
                        string codLanche = linhaLanche["ID"].ToString();
                        string codQtd = linhaLanche["Qtd"].ToString();
                        string codSubTotal = linhaLanche["SubTotal"].ToString();

                        ItensVendaLanche objLanche =  new ItensVendaLanche();
                        objLanche.vendaCodigo = daoVenda.RetornaIdVenda();
                        objLanche.codigoLanche = int.Parse(codLanche);
                        objLanche.quantidadeUtilizada = int.Parse(codQtd);
                        objLanche.subTotal = decimal.Parse(codSubTotal);

                        //Cadastra o lanche e quantidade
                        ItensVendaLancheDAO daoLanche = new ItensVendaLancheDAO();
                        daoLanche.CadastraItemVendaLanche(objLanche);
                    }

                    foreach (DataRow linhaIngrediente in carrinhoIngrediente.Rows)
                    {
                        string codigoIngrediente = linhaIngrediente["ID"].ToString();
                        string quantidadeUtilizada = linhaIngrediente["Qtd"].ToString();

                        ItensVenda objVenda = new ItensVenda();
                        objVenda.vendaCodigo = daoVenda.RetornaIdVenda();
                        objVenda.codigoIngrediente = int.Parse(codigoIngrediente);
                        objVenda.quantidadeUtilizada = int.Parse(quantidadeUtilizada);

                        //Baixa estoque
                        quantidade_estoque = daoIngrediente.RetornaEstoqueAtual(objVenda.codigoIngrediente);
                        quantidade_comprada = objVenda.quantidadeUtilizada;

                        if (quantidade_comprada > quantidade_estoque)
                        {
                            MessageBox.Show("Não é possivel realizar a baixa no estoque pois os ingredientes acabaram!");
                        }
                        else
                        {
                            //Verificacao
                            quantidade_atualizada = quantidade_estoque - quantidade_comprada;

                            //Debita os ingredientes do estoque
                            daoIngrediente.BaixaEstoqueIngrediente(objVenda.codigoIngrediente, quantidade_atualizada);

                            ItensVendaDAO daoItem = new ItensVendaDAO();

                            //Cadastra os ingredientes
                            daoItem.CadastraItemVenda(objVenda);

                            this.Close();
                        }
                    }

                    formPedido.Close();
                    this.Close();

                    FormCadPedido tela = new FormCadPedido();
                    tela.Show();
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO: " + erro);
            }
        }

        private void FormPagamento_Load(object sender, EventArgs e)
        {
            txtDinheiro.Text = "0,00";
            txtTrocado.Text = "0,00";
        }

        private void txtDinheiro_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Variaveis para manipulacao de valores
            decimal valorDinheiro, valorTroco, valorPago, total;

            try
            {
                // Inicializa as variáveis
                valorDinheiro = 0;
                valorTroco = 0;

                // Verifica se o campo txtDinheiro não está vazio
                if (!string.IsNullOrEmpty(txtDinheiro.Text))
                {
                    // Tenta converter o valor do campo txtDinheiro em decimal
                    if (decimal.TryParse(txtDinheiro.Text, out valorDinheiro))
                    {
                        // Tenta converter o valor do campo txtTotal em decimal
                        if (decimal.TryParse(txtTotal.Text, out total))
                        {
                            // Verifica se o valor é maior que zero
                            if (valorDinheiro > 0)
                            {
                                valorPago = valorDinheiro;

                                // Calcula o troco
                                valorTroco = valorPago - total;
                            }
                        }
                    }
                }

                // Define o texto do campo txtTrocado de acordo com o valor calculado
                txtTrocado.Text = (valorDinheiro == 0 || string.IsNullOrEmpty(txtDinheiro.Text)) ? "0" : valorTroco.ToString();

            }
            catch
            {

            }

        }
    }
}
