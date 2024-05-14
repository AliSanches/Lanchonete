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
    public class ItensVendaLancheDAO
    {
        #region CadastraItemVendaLanche
        public void CadastraItemVendaLanche(ItensVendaLanche obj)
        {
            try
            {
                //Abrindo conexao
                Conexao conexao = new Conexao();
                conexao.Conectar();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.conecta;

                cmd.CommandText = "INSERT INTO itens_venda_Lanche (venda_id, id_lanche, quantidade_utilizada, subtotal)" +
                    "VALUES (@idVenda, @idLanche, @quantidade, @subtotal)";

                cmd.Parameters.AddWithValue("@idVenda", obj.vendaCodigo);
                cmd.Parameters.AddWithValue("@idLanche", obj.codigoLanche);
                cmd.Parameters.AddWithValue("@quantidade", obj.quantidadeUtilizada);
                cmd.Parameters.AddWithValue("@subtotal", obj.subTotal);

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

        #region ListarItensVendaLanche
        public DataTable ListarItemVendaLanche(int idVenda)
        {
            try
            {
                Conexao conexao = new Conexao();
                conexao.Conectar();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.conecta;

                DataTable tabela = new DataTable();

                cmd.CommandText = "SELECT itens_venda_lanche.id_itens_venda AS ID," +
                    " lanche.nome_lanche AS Lanche, itens_venda_lanche.quantidade_utilizada AS QtdUtilizada," + " itens_venda_lanche.subtotal AS SubTotal " +
                    " FROM itens_venda_lanche INNER JOIN lanche ON" +
                    " itens_venda_lanche.id_lanche = lanche.id_lanche WHERE venda_id = @venda";

                cmd.Parameters.AddWithValue("@venda", idVenda);

                cmd.Prepare();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter r = new MySqlDataAdapter(cmd);
                r.Fill(tabela);

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
