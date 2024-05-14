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
    public class VendaDAO
    {
        #region CadastrarVenda
        public void CadastrarVenda(Venda obj)
        {
            try
            {
                //Abrindo conexao
                Conexao conexao = new Conexao();
                conexao.Conectar();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.conecta;

                cmd.CommandText = "INSERT INTO venda (data_venda, id_cliente, id_lanche, total_venda)" +
                    "VALUES (@data, @idCliente, @idLanche, @total)";

                cmd.Parameters.AddWithValue("@data", obj.dataVenda);
                cmd.Parameters.AddWithValue("@idCliente", obj.idCliente);
                cmd.Parameters.AddWithValue("@idLanche", obj.idLanche);
                cmd.Parameters.AddWithValue("@total", obj.totalVenda);

                cmd.Prepare();
                cmd.ExecuteNonQuery();

                MessageBox.Show("VENDA REALIZADA", "FINALIZADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO: " + erro);
            }
        }
        #endregion

        #region RetornaIdUltimaVenda
        public int RetornaIdVenda()
        {
            try
            {
                int idVenda = 0;

                //Abrindo conexao
                Conexao conexao = new Conexao();
                conexao.Conectar();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.conecta;

                cmd.CommandText = "SELECT MAX(id_venda) id_venda FROM venda";

                MySqlDataReader resultado = cmd.ExecuteReader();

                if(resultado.Read())
                {
                    idVenda = resultado.GetInt32("id_venda");
                }
                conexao.Desconectar();
                return idVenda;
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO: " + erro);
                return 0;
            }
        }
        #endregion

        #region ListarPorPeriodo
        public DataTable ListarPorPeriodo(DateTime inicio, DateTime final)
        {
            try
            {
                Conexao conexao = new Conexao();
                conexao.Conectar();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.conecta;

                DataTable tabela = new DataTable();

                cmd.CommandText = "SELECT venda.id_venda AS ID, venda.data_venda AS DataVenda, cliente.nome AS idCliente, lanche.nome_lanche AS idLanche, venda.total_venda AS Total " +
                "FROM venda INNER JOIN cliente ON venda.id_cliente = cliente.id_cliente INNER JOIN lanche ON venda.id_lanche = lanche.id_lanche WHERE venda.data_venda BETWEEN @inicio AND @final ";

                cmd.Parameters.AddWithValue("@inicio", inicio);
                cmd.Parameters.AddWithValue("@final", final);

                cmd.Prepare();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter r = new MySqlDataAdapter(cmd);
                r.Fill(tabela);

                return tabela;

            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO: " + erro);
                return null;
            }
        }
        #endregion

        #region ListarVenda
        public DataTable ListarVendas()
        {
            try
            {
                Conexao conexao = new Conexao();
                conexao.Conectar();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.conecta;

                DataTable tabela = new DataTable();

                cmd.CommandText = "SELECT venda.id_venda AS ID, venda.data_venda AS DataVenda, cliente.nome AS idCliente, lanche.nome_lanche AS idLanche, venda.total_venda AS Total " +
                "FROM venda INNER JOIN cliente ON venda.id_cliente = cliente.id_cliente INNER JOIN lanche ON venda.id_lanche = lanche.id_lanche";

                cmd.ExecuteNonQuery();

                MySqlDataAdapter r = new MySqlDataAdapter(cmd);
                r.Fill(tabela);

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
