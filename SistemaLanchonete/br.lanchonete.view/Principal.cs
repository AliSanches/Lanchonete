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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void CarregarFormularioNoPanel(Form formulario)
        {
            // Define o formulário como controle filho do panelContainer
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            // Remove qualquer controle existente no panelContainer
            pnExibicao.Controls.Clear();

            // Adiciona o formulário ao panelContainer
            pnExibicao.Controls.Add(formulario);

            // Exibe o formulário
            formulario.Show();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();

            FormLogin login = new FormLogin();
            login.Show();
        }

        private void btMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btEstoque_Click(object sender, EventArgs e)
        {
            lbAltera.Text = "ESTOQUE";

            teste forms = new teste();
            CarregarFormularioNoPanel(forms);

        }

        private void btHome_Click(object sender, EventArgs e)
        {
            lbAltera.Text = "HOME";

            Logo logo = new Logo();
            CarregarFormularioNoPanel(logo);
        }

        private void pnExibicao_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbAltera.Text = "LANCHES";

            Lanches tela = new Lanches();
            CarregarFormularioNoPanel(tela);
        }

        private void btUsuario_Click(object sender, EventArgs e)
        {
            lbAltera.Text = "FUNCIONARIOS";

            FormUsuario telaUsuario = new FormUsuario();
            CarregarFormularioNoPanel(telaUsuario);
        }

        private void btCliente_Click(object sender, EventArgs e)
        {
            lbAltera.Text = "CLIENTES";

            FormCliente telaCliente = new FormCliente();
            CarregarFormularioNoPanel(telaCliente);
        }

        private void btPedido_Click(object sender, EventArgs e)
        {
            lbAltera.Text = "PEDIDOS";

            FormPedido telaPedido = new FormPedido();
            CarregarFormularioNoPanel(telaPedido);
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
