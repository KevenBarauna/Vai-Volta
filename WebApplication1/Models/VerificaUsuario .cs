using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class VerificaUsuario
    {

        Conexao conexao = new Conexao();
        SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
        public Boolean reult;
        public VerificaUsuario(String Nome, String Email, String Senha)
        {
            //COMANDO SQL -- SELECT -- SqlCommand
            cmd.CommandText = ("select from pessoa where usuario = ?, Nome");


            //PARAMETROS
            cmd.Parameters.AddWithValue("@Nome", Nome);


            //CONECTAR COM BANCO -- Classe Conexao
            try
            {
                cmd.Connection = conexao.conectar();

                //EXECUTAR COMANDO
                cmd.ExecuteNonQuery();

                //DESCONECTAR
                conexao.desconectar();

                //MOSTRAR MENSAGEM
                this.reult = true;
            }
            catch (SqlException)
            {
                this.reult = false;
            }

        }

    }
}