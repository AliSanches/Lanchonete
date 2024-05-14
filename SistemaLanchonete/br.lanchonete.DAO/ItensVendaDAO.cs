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
    public class ItensVendaDAO
    {
        #region CadastraItemVenda
        public void CadastraItemVenda(ItensVenda obj)
        {
            try
            {
                //Abrindo conexao
                Conexao conexao = new Conexao();
                conexao.Conectar();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.conecta;

                cmd.CommandText = "INSERT INTO itens_venda (venda_id, id_ingrediente, quantidade_utilizada)" +
                    "VALUES (@idVenda, @idIngrediente, @quantidade)";

                cmd.Parameters.AddWithValue("@idVenda", obj.vendaCodigo);
                cmd.Parameters.AddWithValue("@idIngrediente", obj.codigoIngrediente);
                cmd.Parameters.AddWithValue("@quantidade", obj.quantidadeUtilizada);

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

        #region ListarItensVenda
        public DataTable ListarItemVenda(int idVenda)
        {
            try
            {
                Conexao conexao = new Conexao();
                conexao.Conectar();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.conecta;

                DataTable tabela = new DataTable();

                cmd.CommandText = "SELECT itens_venda.id_itens_venda AS ID," +
                    " ingrediente.nome_ingrediente AS Ingrediente, itens_venda.quantidade_utilizada AS QtdUtilizada" +
                    " FROM itens_venda INNER JOIN ingrediente ON" +
                    " itens_venda.id_ingrediente = ingrediente.id_ingrediente WHERE venda_id = @venda";

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

                cmd.CommandText = "SELECT itens_venda.id_itens_venda AS IDLanche," + " lanche.nome_lanche AS Lanche, " +
                    " itens_venda.quantidade_lanche AS Quantidade" +
                    " FROM itens_venda INNER JOIN lanche ON itens_venda.id_lanche = lanche.id_lanche INNER JOIN ingrediente ON" +
                    " itens_venda.id_ingrediente = ingrediente.id_ingrediente WHERE venda_id = @venda";

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
