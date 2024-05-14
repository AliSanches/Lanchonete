using MySql.Data.MySqlClient;
using SistemaLanchonete.br.lanchonete.conexao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLanchonete
{
    public class UsuarioDAO
    {
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

                cmd.CommandText = "INSERT INTO usuario (id_usuario, nome_completo, cpf, email, nome_login, senha, telefone, celular, estado, cidade, bairro, rua, numero)" +
                    " VALUES (@id, @nome, @cpf, @email, @nomeLogin, @senha, @telefone, @celular, @estado, @cidade, @bairro, @rua, @numero)";

                cmd.Parameters.AddWithValue("@id", obj.codigo);
                cmd.Parameters.AddWithValue("@nome", obj.nomeCompleto);
                cmd.Parameters.AddWithValue("@cpf", obj.cpf);
                cmd.Parameters.AddWithValue("@email", obj.email);
                cmd.Parameters.AddWithValue("@nomeLogin", obj.nomeLogin);
                cmd.Parameters.AddWithValue("@senha", obj.senha);
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

                cmd.CommandText = "UPDATE usuario SET nome_completo=@nome, quantidade_estoque=@quantidade, preco_ingrediente=@preco WHERE id_ingrediente=@codigo";

                cmd.Parameters.AddWithValue("@id", obj.codigo);
                cmd.Parameters.AddWithValue("@nome", obj.nomeCompleto);
                cmd.Parameters.AddWithValue("@cpf", obj.cpf);
                cmd.Parameters.AddWithValue("@email", obj.email);
                cmd.Parameters.AddWithValue("@nomeLogin", obj.nomeLogin);
                cmd.Parameters.AddWithValue("@senha", obj.senha);
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

        #region ExcluirIngrediente
        public void ExcluirIngrediente(Ingrediente obj)
        {
            try
            {
                //Abrindo conexao
                Conexao conexao = new Conexao();
                conexao.Conectar();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.conecta;

                cmd.CommandText = "DELETE FROM ingrediente WHERE id_ingrediente=@codigo";

                cmd.Parameters.AddWithValue("@codigo", obj.codigo);

                cmd.Prepare();
                cmd.ExecuteNonQuery();

                MessageBox.Show("INGREDIENTE EXCLUIDO", "EXCLUIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO: " + erro);
            }
        }

        #endregion

        #region ListarIngrediente
        public DataTable ListarIngrediente()
        {
            try
            {
                Conexao conexao = new Conexao();
                conexao.Conectar();

                DataTable tabela = new DataTable();
                string sql = "SELECT id_ingrediente AS ID, nome_ingrediente AS Nome, quantidade_estoque AS Ingredientes, preco_ingrediente AS Valor FROM ingrediente;";

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

        #region BuscarIngredientePorNome
        public DataTable BuscarIngredienteNome(string nome)
        {
            try
            {
                Conexao conexao = new Conexao();
                conexao.Conectar();

                DataTable tabela = new DataTable();
                string sql = "SELECT id_ingrediente AS ID, nome_ingrediente AS Nome, quantidade_estoque AS Ingredientes, preco_ingrediente AS Valor FROM ingrediente WHERE nome_ingrediente=@nome";

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

        #region ListarIngredientePorNome
        public DataTable ListarIngredientePorNome(string nome)
        {
            try
            {
                Conexao conexao = new Conexao();
                conexao.Conectar();

                DataTable tabela = new DataTable();
                string sql = "SELECT id_ingrediente AS ID, nome_ingrediente AS Nome, quantidade_estoque AS Ingredientes, preco_ingrediente AS Valor FROM ingrediente WHERE nome_ingrediente LIKE @nome";

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
    }
}
