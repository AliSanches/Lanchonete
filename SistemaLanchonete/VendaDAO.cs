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

                cmd.CommandText = "INSERT INTO venda (data_venda, id_cliente, id_lanche, total_venda" +
                    "VALUES (@data, @idCliente, @idLanche, @total)";

                cmd.Parameters.AddWithValue("@data", obj.codigo);
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

                cmd.CommandText = "SELECT MAX(id_venda) FROM venda";

                cmd.ExecuteNonQuery();

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
    }
}
