using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Conexao
    {


        SqlConnection con = new SqlConnection();

        //CONSTRUTOR
        public Conexao()
        {
            con.ConnectionString = "Server=localhost;Database=item;Uid=root";
        }

        //METODO CONEXÃO
        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        //METODO DESCONECTAR
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }




    }
}