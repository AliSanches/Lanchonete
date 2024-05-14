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

                cmd.CommandText = "INSERT INTO itens_venda (venda_id, id_lanche, id_ingrediente, quantidade_utilizada)" +
                    "VALUES (@idVenda, @idLanche, @idIngrediente, @quantidade)";

                cmd.Parameters.AddWithValue("@idVenda", obj.vendaCodigo);
                cmd.Parameters.AddWithValue("@idLanche", obj.codigoLanche);
                cmd.Parameters.AddWithValue("@idIngrediente", obj.codigoIngrediente);
                cmd.Parameters.AddWithValue("@quantidade", obj.quantidadeUtilizada);

                cmd.Prepare();
                cmd.ExecuteNonQuery();

                MessageBox.Show("ITEM CADASTRADO", "CADASTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO: " + erro);
            }
        }
        #endregion
    }
}
