using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using MySql.Data.MySqlClient;

namespace SistemaLanchonete.br.lanchonete.conexao
{
    public class Conexao
    {
        public MySqlConnection conecta = new MySqlConnection("datasource=localhost;username=root;password=;database=lanchonete");

        public void Conectar()
        {
            conecta.Open();
        }

        public void Desconectar()
        {
            conecta.Close();
        }

    }
}
