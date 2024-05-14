using SistemaLanchonete.br.lanchonete.view;
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void lbSair_Click(object sender, EventArgs e)
        {
            // Create a copy of the open forms collection
            Form[] openForms = Application.OpenForms.Cast<Form>().ToArray();

            // Close all open forms
            foreach (Form form in openForms)
            {
                form.Close();
            }

            // Exit the application
            Application.Exit();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string senha = txtSenha.Text;

            UsuarioDAO dao = new UsuarioDAO();

            if (dao.Login(login, senha))
            {
                this.Hide();
            }
            else
            {
                MessageBox.Show("PREENCHA TODOS OS CAMPOS!");
            }
        }
    }
}
