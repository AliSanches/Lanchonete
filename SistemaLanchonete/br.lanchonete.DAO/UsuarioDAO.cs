using MySql.Data.MySqlClient;
using SistemaLanchonete.br.lanchonete.conexao;
using SistemaLanchonete.br.lanchonete.model;
using SistemaLanchonete.br.lanchonete.view;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SistemaLanchonete
{
    public class UsuarioDAO
    {

        #region MetodosDeVerificacao
        // Método para verificar se um campo de texto está vazio
        private bool CampoVazio(string texto)
        {
            return string.IsNullOrWhiteSpace(texto);
        }

        // Método para verificar se um campo de texto contém apenas números
        private bool ApenasNumeros(string texto)
        {
            return texto.All(char.IsDigit);
        }

        public bool CamposValidos(Usuario obj)
        {
            // Verificar se todos os campos obrigatórios foram preenchidos
            if (CampoVazio(obj.nomeCompleto) || CampoVazio(obj.cpf) || CampoVazio(obj.email) || CampoVazio(obj.senha) || CampoVazio(obj.nomeLogin) || CampoVazio(obj.acesso) || CampoVazio(obj.celular) || CampoVazio(obj.estado) || CampoVazio(obj.cidade) || CampoVazio(obj.bairro) || CampoVazio(obj.rua))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Verificar se campos numéricos contêm apenas números
            if (!ApenasNumeros(obj.numero.ToString()))
            {
                MessageBox.Show("Campos numéricos devem conter apenas números.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Todos os campos estão válidos
            return true;
        }
        #endregion

        #region CadastrarUsuario
        public void CadastrarUsuario(Usuario obj)
        {
            try
            {
                //Abrindo conexao
                Conexao conexao = new Conexao();
                conexao.Conectar();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.conecta;

                cmd.CommandText = "INSERT INTO usuario (id_usuario, nome_completo, cpf, email, nome_login, senha, nivel_acesso, telefone, celular, estado, cidade, bairro, rua, numero)" +
                    " VALUES (@id, @nome, @cpf, @email, @nomeLogin, @senha, @acesso, @telefone, @celular, @estado, @cidade, @bairro, @rua, @numero)";

                cmd.Parameters.AddWithValue("@id", obj.codigo);
                cmd.Parameters.AddWithValue("@nome", obj.nomeCompleto);
                cmd.Parameters.AddWithValue("@cpf", obj.cpf);
                cmd.Parameters.AddWithValue("@email", obj.email);
                cmd.Parameters.AddWithValue("@nomeLogin", obj.nomeLogin);
                cmd.Parameters.AddWithValue("@senha", obj.senha);
                cmd.Parameters.AddWithValue("@acesso", obj.acesso);
                cmd.Parameters.AddWithValue("@telefone", obj.telefone);
                cmd.Parameters.AddWithValue("@celular", obj.celular);
                cmd.Parameters.AddWithValue("@estado", obj.estado);
                cmd.Parameters.AddWithValue("@cidade", obj.cidade);
                cmd.Parameters.AddWithValue("@bairro", obj.bairro);
                cmd.Parameters.AddWithValue("@rua", obj.rua);
                cmd.Parameters.AddWithValue("@numero", obj.numero);

                cmd.Prepare();
                cmd.ExecuteNonQuery();

                MessageBox.Show("USUÁRIO CADASTRADO", "CADASTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO: " + erro);
            }
        }
        #endregion

        #region EditarUsuario
        public void AlterarUsuario(Usuario obj)
        {
            try
            {
                //Abrindo conexao
                Conexao conexao = new Conexao();
                conexao.Conectar();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.conecta;

                cmd.CommandText = "UPDATE usuario SET id_usuario=@id, nome_completo=@nome, cpf=@cpf, email=@email, nome_login=@nomeLogin, senha=@senha, nivel_acesso=@acesso, telefone=@telefone, celular=@celular, estado=@estado, cidade=@cidade, bairro=@bairro, rua=@rua, numero=@numero WHERE id_usuario=@id";

                cmd.Parameters.AddWithValue("@id", obj.codigo);
                cmd.Parameters.AddWithValue("@nome", obj.nomeCompleto);
                cmd.Parameters.AddWithValue("@cpf", obj.cpf);
                cmd.Parameters.AddWithValue("@email", obj.email);
                cmd.Parameters.AddWithValue("@nomeLogin", obj.nomeLogin);
                cmd.Parameters.AddWithValue("@senha", obj.senha);
                cmd.Parameters.AddWithValue("@acesso", obj.acesso);
                cmd.Parameters.AddWithValue("@telefone", obj.telefone);
                cmd.Parameters.AddWithValue("@celular", obj.celular);
                cmd.Parameters.AddWithValue("@estado", obj.estado);
                cmd.Parameters.AddWithValue("@cidade", obj.cidade);
                cmd.Parameters.AddWithValue("@bairro", obj.bairro);
                cmd.Parameters.AddWithValue("@rua", obj.rua);
                cmd.Parameters.AddWithValue("@numero", obj.numero);

                cmd.Prepare();
                cmd.ExecuteNonQuery();

                MessageBox.Show("USUÁRIO ALTERADO", "ALTERADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO: " + erro);
            }
        }
        #endregion

        #region ExcluirUsuario
        public void ExcluirUsuario(Usuario obj)
        {
            try
            {
                //Abrindo conexao
                Conexao conexao = new Conexao();
                conexao.Conectar();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.conecta;

                cmd.CommandText = "DELETE FROM usuario WHERE id_usuario=@codigo";

                cmd.Parameters.AddWithValue("@codigo", obj.codigo);

                cmd.Prepare();
                cmd.ExecuteNonQuery();

                MessageBox.Show("USUARIO EXCLUIDO", "EXCLUIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO: " + erro);
            }
        }

        #endregion

        #region ListarUsuario
        public DataTable ListarUsuario()
        {
            try
            {
                Conexao conexao = new Conexao();
                conexao.Conectar();

                DataTable tabela = new DataTable();
                string sql = "SELECT id_usuario AS ID, nome_completo AS Nome, cpf AS Cpf, nivel_acesso AS Acesso, celular AS Contato, telefone AS Telefone, email AS Email, " +
                    "nome_login AS Login, senha AS Senha, estado AS UF, cidade AS Cidade, bairro AS Bairro, rua as Rua, numero as Numero  FROM usuario";

                MySqlCommand cmd = new MySqlCommand(sql, conexao.conecta);

                MySqlDataAdapter preenche = new MySqlDataAdapter(cmd);
                preenche.Fill(tabela);

                conexao.Desconectar();

                return tabela;

            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO: " + erro);
                return null;
            }
        }
        #endregion

        #region BuscarUsuarioPorNome
        public DataTable BuscarUsuarioNome(string nome)
        {
            try
            {
                Conexao conexao = new Conexao();
                conexao.Conectar();

                DataTable tabela = new DataTable();
                string sql = "SELECT id_usuario AS ID, nome_completo AS Nome, cpf AS Cpf, nivel_acesso AS Acesso, celular AS Contato, telefone AS Telefone, email AS Email, nome_login AS Login, senha AS Senha, estado AS UF, cidade AS Cidade, bairro AS Bairro, rua as Rua, numero as Numero FROM usuario WHERE nome_completo=@nome";

                MySqlCommand cmd = new MySqlCommand(sql, conexao.conecta);
                cmd.Parameters.AddWithValue("@nome", nome);

                MySqlDataAdapter preenche = new MySqlDataAdapter(cmd);
                preenche.Fill(tabela);

                conexao.Desconectar();

                return tabela;

            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO: " + erro);
                return null;
            }
        }
        #endregion

        #region ListarUsuarioPorNome
        public DataTable ListarUsuarioPorNome(string nome)
        {
            try
            {
                Conexao conexao = new Conexao();
                conexao.Conectar();

                DataTable tabela = new DataTable();
                string sql = "SELECT id_usuario AS ID, nome_completo AS Nome, cpf AS Cpf, nivel_acesso AS Acesso, celular AS Contato, telefone AS Telefone, email AS Email, nome_login AS Login, senha AS Senha, estado AS UF, cidade AS Cidade, bairro AS Bairro, rua as Rua, numero as Numero FROM usuario WHERE nome_completo LIKE @nome";

                MySqlCommand cmd = new MySqlCommand(sql, conexao.conecta);
                cmd.Parameters.AddWithValue("@nome", nome);

                MySqlDataAdapter preenche = new MySqlDataAdapter(cmd);
                preenche.Fill(tabela);

                conexao.Desconectar();

                return tabela;

            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO: " + erro);
                return null;
            }
        }
        #endregion

        #region Login
        public bool Login(string login, string senha)
        {
            try
            {
                Conexao conexao = new Conexao();
                conexao.Conectar();

                Usuario obj = new Usuario();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.conecta;

                cmd.CommandText = "SELECT * FROM usuario WHERE nome_login=@login AND senha=@senha";

                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@senha", senha);

                MySqlDataReader resultado = cmd.ExecuteReader();

                if (resultado.Read())
                {
                    //Variaveis
                    string nivelAcesso = resultado.GetString("nivel_acesso");
                    string nome = resultado.GetString("nome_completo");

                    MessageBox.Show("BEM VINDO(A) " + nome + "!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Abrir Form
                    Principal tela = new Principal();

                    if(nivelAcesso.Equals("Administrador"))
                    {
                        tela.Show();
                    }
                    else if(nivelAcesso.Equals("Comum"))
                    {
                        //Acessos Bloq para usuario comum
                        tela.btCliente.Enabled = false;
                        tela.btCliente.Visible = false;
                        tela.btPedido.Enabled = false;
                        tela.btPedido.Visible = false;
                        tela.btUsuario.Enabled = false;
                        tela.btUsuario.Visible = false;
                        tela.Show();
                    }

                    conexao.Desconectar();
                }
                else
                {

                    MessageBox.Show("NOME DE USUÁRIO OU SENHA INCORRETO", "ACESSO NEGADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conexao.Desconectar();
                    return false;
                }
                return true;
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO: " + erro);
                return false;
            }
        }
        #endregion
    }
}
