using MySql.Data.MySqlClient;
using SistemaLanchonete.br.lanchonete.conexao;
using SistemaLanchonete.br.lanchonete.model;
using SistemaLanchonete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection.Emit;

namespace SistemaLanchonete.br.lanchonete.DAO
{
    public class IngredienteDAO
    {
        #region CadastrarIngrediente
        public void CadastrarIngrediente(Ingrediente obj)
        {
            try
            {
                //Abrindo conexao
                Conexao conexao = new Conexao();
                conexao.Conectar();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.conecta;

                cmd.CommandText = "INSERT INTO ingrediente (id_ingrediente, nome_ingrediente, quantidade_estoque, preco_ingrediente) VALUES (@id, @nome, @quantidade, @preco)";

                cmd.Parameters.AddWithValue("@id", obj.codigo);
                cmd.Parameters.AddWithValue("@nome", obj.nome);
                cmd.Parameters.AddWithValue("@quantidade", obj.quantidade);
                cmd.Parameters.AddWithValue("@preco", obj.preco);

                cmd.Prepare();
                cmd.ExecuteNonQuery();

                MessageBox.Show("INGREDIENTE CADASTRADO", "CADASTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO: " + erro);
            }
        }
        #endregion

        #region EditarIngrediente
        public void AlterarIngrediente(Ingrediente obj)
        {
            try
            {
                //Abrindo conexao
                Conexao conexao = new Conexao();
                conexao.Conectar();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.conecta;

                cmd.CommandText = "UPDATE ingrediente SET nome_ingrediente=@nome, quantidade_estoque=@quantidade, preco_ingrediente=@preco WHERE id_ingrediente=@codigo";

                cmd.Parameters.AddWithValue("@nome", obj.nome);
                cmd.Parameters.AddWithValue("@quantidade", obj.quantidade);
                cmd.Parameters.AddWithValue("@preco", obj.preco);
                cmd.Parameters.AddWithValue("@codigo", obj.codigo);

                cmd.Prepare();
                cmd.ExecuteNonQuery();

                MessageBox.Show("INGREDIENTE ALTERADO", "ALTERADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        #region RetornaIngredientePorNome
        public Ingrediente RetornaIngredientePorNome(string nome)
        {
            try
            {
                Conexao conexao = new Conexao();
                conexao.Conectar();

                Ingrediente obj = new Ingrediente();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.conecta;

                cmd.CommandText = "SELECT * FROM ingrediente WHERE nome_ingrediente = @nome";

                cmd.Parameters.AddWithValue("@nome", nome);

                MySqlDataReader resultado = cmd.ExecuteReader();

                if (resultado.Read())
                {
                    obj.codigo = resultado.GetString("id_ingrediente");
                    obj.nome = resultado.GetString("nome_ingrediente");

                    conexao.Desconectar();

                    return obj;
                }
                else
                {
                    MessageBox.Show("ERRO AO REALIZAR A LEITURA DOS DADOS");

                    conexao.Desconectar();

                    return null;
                }
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

        #region PreencherUmComboBox
        public void PreencherComboBox(ComboBox box)
        {
            try
            {
                Conexao conexao = new Conexao();
                conexao.Conectar();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.conecta;

                cmd.CommandText = "SELECT id_ingrediente, nome_ingrediente FROM ingrediente ORDER BY nome_ingrediente";

                MySqlDataReader resultado = cmd.ExecuteReader();

                DataTable tabela = new DataTable();
                tabela.Load(resultado);

                DataRow linha = tabela.NewRow();
                linha["id_ingrediente"] = -1; // ou qualquer outro valor que não exista no banco de dados
                linha["nome_ingrediente"] = ""; // ou outro valor padrão, se necessário
                tabela.Rows.InsertAt(linha, 0);

                box.DataSource = tabela;
                box.ValueMember = "id_ingrediente";
                box.DisplayMember = "nome_ingrediente";

                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO: " + erro);
            }
        }
        #endregion

        #region BaixaEstoqueIngrediente
        public void BaixaEstoqueIngrediente(int idIngrediente, int quantidade)
        {
            try
            {
                //Abrindo conexao
                Conexao conexao = new Conexao();
                conexao.Conectar();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.conecta;

                cmd.CommandText = "UPDATE ingrediente SET quantidade_estoque=@quantidade WHERE id_ingrediente=@id";

                cmd.Parameters.AddWithValue("@id", idIngrediente);
                cmd.Parameters.AddWithValue("@quantidade", quantidade);

                cmd.Prepare();
                cmd.ExecuteNonQuery();

                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO: " + erro);
            }
        }
        #endregion

        #region RetornaEstoqueAtual
        public int RetornaEstoqueAtual(int idIngrediente)
        {
            try
            {
                //Declaro minha variavel sendo 0
                int qtdEstoque = 0;

                //Abrindo conexao
                Conexao conexao = new Conexao();
                conexao.Conectar();

                //Mysql de comandos
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.conecta;

                //Query
                cmd.CommandText = "SELECT quantidade_estoque FROM ingrediente WHERE id_ingrediente=@id";

                //Parametros
                cmd.Parameters.AddWithValue("@id", idIngrediente);

                //Preparação para execucao
                cmd.Prepare();

                //Executa e retorna o valor da coluna
                MySqlDataReader resultado = cmd.ExecuteReader();
                if(resultado.Read())
                {
                    qtdEstoque = resultado.GetInt32("quantidade_estoque");
                    conexao.Desconectar();
                }

                //Retorna o novo valor da variavel apos passar pela execucao e receber valores
                return qtdEstoque;
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO: " + erro);
                return 0;
            }
        }
        #endregion

    }
}
