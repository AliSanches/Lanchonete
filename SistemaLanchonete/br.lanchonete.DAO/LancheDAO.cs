using MySql.Data.MySqlClient;
using SistemaLanchonete.br.lanchonete.conexao;
using SistemaLanchonete.br.lanchonete.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SistemaLanchonete.br.lanchonete.DAO
{
    public class LancheDAO
    {

        #region CadastrarLanche
        public void CadastrarLanche(Lanche obj)
        {
            try
            {
                //Abrindo conexao
                Conexao conexao = new Conexao();
                conexao.Conectar();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.conecta;

                cmd.CommandText = "INSERT INTO lanche (id_lanche, nome_lanche, descricao_lanche, preco_lanche) VALUES (@id, @nome, @descricao, @preco)";

                cmd.Parameters.AddWithValue("@id", obj.codigo);
                cmd.Parameters.AddWithValue("@nome", obj.nome);
                cmd.Parameters.AddWithValue("@descricao", obj.ingrediente);
                cmd.Parameters.AddWithValue("@preco", obj.preco);

                cmd.Prepare();
                cmd.ExecuteNonQuery();

                MessageBox.Show("LANCHE CADASTRADO", "CADASTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conexao.Desconectar();
            }
            catch(Exception erro)
            {
                MessageBox.Show("ERRO: " + erro);
            }
        }
        #endregion

        #region EditarLanche
        public void AlterarLanche(Lanche obj)
        {
            try
            {
                //Abrindo conexao
                Conexao conexao = new Conexao();
                conexao.Conectar();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.conecta;

                cmd.CommandText = "UPDATE lanche SET nome_lanche=@nome, descricao_lanche=@descricao, preco_lanche=@preco WHERE id_lanche=@codigo";

                cmd.Parameters.AddWithValue("@nome", obj.nome);
                cmd.Parameters.AddWithValue("@descricao", obj.ingrediente);
                cmd.Parameters.AddWithValue("@preco", obj.preco);
                cmd.Parameters.AddWithValue("@codigo", obj.codigo);

                cmd.Prepare();
                cmd.ExecuteNonQuery();

                MessageBox.Show("LANCHE ALTERADO", "ALTERADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO: " + erro);
            }
        }
        #endregion

        #region ExcluirLanche
        public void ExcluirLanche(Lanche obj)
        {
            try
            {
                //Abrindo conexao
                Conexao conexao = new Conexao();
                conexao.Conectar();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.conecta;

                cmd.CommandText = "DELETE FROM lanche WHERE id_lanche=@codigo";

                cmd.Parameters.AddWithValue("@codigo", obj.codigo);

                cmd.Prepare();
                cmd.ExecuteNonQuery();

                MessageBox.Show("LANCHE EXCLUIDO", "EXCLUIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO: " + erro);
            }
        }

        #endregion

        #region ListarLanches
        public DataTable ListarLanche()
        {
            try
            {
                Conexao conexao = new Conexao();
                conexao.Conectar();

                DataTable tabela = new DataTable();
                string sql = "SELECT id_lanche AS ID, nome_lanche AS Nome, descricao_lanche AS Ingredientes, preco_lanche AS Valor FROM lanche";

                MySqlCommand cmd = new MySqlCommand(sql, conexao.conecta);

                MySqlDataAdapter preenche = new MySqlDataAdapter(cmd);
                preenche.Fill(tabela);

                conexao.Desconectar();

                return tabela;

            }
            catch(Exception erro)
            {
                MessageBox.Show("ERRO: " + erro);
                return null;
            }
        }
        #endregion

        #region RetornaLanchePorNome
        public Lanche RetornaLanchePorNome(string nome)
        {
            try
            {
                Conexao conexao = new Conexao();
                conexao.Conectar();

                Lanche obj = new Lanche();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.conecta;

                cmd.CommandText = "SELECT * FROM lanche WHERE nome_lanche = @nome";

                cmd.Parameters.AddWithValue("@nome", nome);

                MySqlDataReader resultado = cmd.ExecuteReader();

                if (resultado.Read())
                {
                    obj.codigo = resultado.GetString("id_lanche");
                    obj.nome = resultado.GetString("nome_lanche");
                    obj.preco = (double)resultado.GetDecimal("preco_lanche");
                    obj.ingrediente = resultado.GetString("descricao_lanche");

                    conexao.Desconectar();

                    return obj;
                }
                else
                {
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

        #region BuscarLanchePorNome
        public DataTable BuscarLancheNome(string nome)
        {
            try
            {
                Conexao conexao = new Conexao();
                conexao.Conectar();

                DataTable tabela = new DataTable();
                string sql = "SELECT id_lanche AS ID, nome_lanche AS Nome, descricao_lanche AS Ingredientes, preco_lanche AS Valor FROM lanche WHERE nome_lanche=@nome";

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

                cmd.CommandText = "SELECT id_lanche, nome_lanche, descricao_lanche, preco_lanche FROM lanche ORDER BY nome_lanche";

                MySqlDataReader resultado = cmd.ExecuteReader();

                DataTable tabela = new DataTable();
                tabela.Load(resultado);

                DataRow linha = tabela.NewRow();
                linha["id_lanche"] = -1; // ou qualquer outro valor que não exista no banco de dados
                linha["nome_lanche"] = "";
                linha["descricao_lanche"] = -1;
                linha["preco_lanche"] = -1;// ou outro valor padrão, se necessário
                tabela.Rows.InsertAt(linha, 0);

                box.DataSource = tabela;
                box.ValueMember = "id_lanche";
                box.DisplayMember = "nome_lanche";

                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO: " + erro);
            }
        }
        #endregion

        #region ListarLanchePorNome
        public DataTable ListarLanchePorNome(string nome)
        {
            try
            {
                Conexao conexao = new Conexao();
                conexao.Conectar();

                DataTable tabela = new DataTable();
                string sql = "SELECT id_lanche AS ID, nome_lanche AS Nome, descricao_lanche AS Ingredientes, preco_lanche AS Valor FROM lanche WHERE nome_lanche LIKE @nome";

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
