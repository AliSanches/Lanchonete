using MySql.Data.MySqlClient;
using SistemaLanchonete.br.lanchonete.conexao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLanchonete
{
    public class ClienteDAO
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

        public bool CamposValidos(Cliente obj)
        {
            // Verificar se todos os campos obrigatórios foram preenchidos
            if (CampoVazio(obj.nomeCompleto) || CampoVazio(obj.cpf) || CampoVazio(obj.celular) || CampoVazio(obj.estado) || CampoVazio(obj.cidade) || CampoVazio(obj.bairro) || CampoVazio(obj.rua))
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

        #region CadastrarCliente
        public void CadastrarCliente(Cliente obj)
        {
            try
            {
                //Abrindo conexao
                Conexao conexao = new Conexao();
                conexao.Conectar();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.conecta;

                cmd.CommandText = "INSERT INTO cliente (id_cliente, nome, cpf, telefone, celular, estado, cidade, bairro, rua, numero)" +
                    " VALUES (@id, @nome, @cpf, @telefone, @celular, @estado, @cidade, @bairro, @rua, @numero)";

                cmd.Parameters.AddWithValue("@id", obj.codigo);
                cmd.Parameters.AddWithValue("@nome", obj.nomeCompleto);
                cmd.Parameters.AddWithValue("@cpf", obj.cpf);
                cmd.Parameters.AddWithValue("@telefone", obj.telefone);
                cmd.Parameters.AddWithValue("@celular", obj.celular);
                cmd.Parameters.AddWithValue("@estado", obj.estado);
                cmd.Parameters.AddWithValue("@cidade", obj.cidade);
                cmd.Parameters.AddWithValue("@bairro", obj.bairro);
                cmd.Parameters.AddWithValue("@rua", obj.rua);
                cmd.Parameters.AddWithValue("@numero", obj.numero);

                cmd.Prepare();
                cmd.ExecuteNonQuery();

                MessageBox.Show("CLIENTE CADASTRADO", "CADASTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO: " + erro);
            }
        }
        #endregion

        #region EditarCliente
        public void AlterarCliente(Cliente obj)
        {
            try
            {
                //Abrindo conexao
                Conexao conexao = new Conexao();
                conexao.Conectar();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.conecta;

                cmd.CommandText = "UPDATE cliente SET id_cliente=@id, nome=@nome, cpf=@cpf, telefone=@telefone, celular=@celular, estado=@estado, cidade=@cidade, bairro=@bairro, rua=@rua, numero=@numero WHERE id_cliente=@id";

                cmd.Parameters.AddWithValue("@id", obj.codigo);
                cmd.Parameters.AddWithValue("@nome", obj.nomeCompleto);
                cmd.Parameters.AddWithValue("@cpf", obj.cpf);
                cmd.Parameters.AddWithValue("@telefone", obj.telefone);
                cmd.Parameters.AddWithValue("@celular", obj.celular);
                cmd.Parameters.AddWithValue("@estado", obj.estado);
                cmd.Parameters.AddWithValue("@cidade", obj.cidade);
                cmd.Parameters.AddWithValue("@bairro", obj.bairro);
                cmd.Parameters.AddWithValue("@rua", obj.rua);
                cmd.Parameters.AddWithValue("@numero", obj.numero);

                cmd.Prepare();
                cmd.ExecuteNonQuery();

                MessageBox.Show("CLIENTE ALTERADO", "ALTERADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO: " + erro);
            }
        }
        #endregion

        #region ExcluirCliente
        public void ExcluirCliente(Cliente obj)
        {
            try
            {
                //Abrindo conexao
                Conexao conexao = new Conexao();
                conexao.Conectar();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.conecta;

                cmd.CommandText = "DELETE FROM cliente WHERE id_cliente=@codigo";

                cmd.Parameters.AddWithValue("@codigo", obj.codigo);

                cmd.Prepare();
                cmd.ExecuteNonQuery();

                MessageBox.Show("CLIENTE EXCLUIDO", "EXCLUIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO: " + erro);
            }
        }

        #endregion

        #region ListarCliente
        public DataTable ListarCliente()
        {
            try
            {
                Conexao conexao = new Conexao();
                conexao.Conectar();

                DataTable tabela = new DataTable();
                string sql = "SELECT id_cliente AS ID, nome AS Nome, cpf AS Cpf, celular AS Contato, telefone AS Telefone, " +
                    "estado AS UF, cidade AS Cidade, bairro AS Bairro, rua as Rua, numero as Numero  FROM cliente";

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

        #region RetornaClientePorCPF
        public Cliente BuscarPorCPF(string cpf)
        {
            try
            {
                Conexao conexao = new Conexao();
                conexao.Conectar();

                Cliente obj = new Cliente();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.conecta;

                cmd.CommandText = "SELECT * FROM cliente WHERE cpf = @cpf";

                cmd.Parameters.AddWithValue("@cpf", cpf);

               MySqlDataReader resultado = cmd.ExecuteReader();

                if(resultado.Read())
                {
                    obj.codigo = resultado.GetInt32("id_cliente");
                    obj.nomeCompleto = resultado.GetString("nome");
                    return obj;
                }
                else
                {
                    MessageBox.Show("ERRO AO REALIZAR A LEITURA DOS DADOS");
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

        #region BuscarClientePorNome
        public DataTable BuscarClienteNome(string nome)
        {
            try
            {
                Conexao conexao = new Conexao();
                conexao.Conectar();

                DataTable tabela = new DataTable();
                string sql = "SELECT id_cliente AS ID, nome AS Nome, cpf AS Cpf, celular AS Contato, telefone AS Telefone, estado AS UF, cidade AS Cidade, bairro AS Bairro, rua as Rua, numero as Numero  FROM cliente WHERE nome=@nome";

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

        #region ListarClientePorNome
        public DataTable ListarClientePorNome(string nome)
        {
            try
            {
                Conexao conexao = new Conexao();
                conexao.Conectar();

                DataTable tabela = new DataTable();
                string sql = "SELECT id_cliente AS ID, nome AS Nome, cpf AS Cpf, celular AS Contato, telefone AS Telefone, estado AS UF, cidade AS Cidade, bairro AS Bairro, rua as Rua, numero as Numero  FROM cliente WHERE nome LIKE @nome";

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
