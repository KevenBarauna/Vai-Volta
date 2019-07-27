using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class CadastrarItem
    {

        Conexao conexao = new Conexao();
        SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
        public Boolean result;
        public CadastrarItem(String Pessoa, String Telefone, String Item, String Data)
        {
            //COMANDO SQL -- INSET  -- SqlCommand
            cmd.CommandText = "insert into item (Pessoa, Telefone, Item, Data) values (@Pessoa, @Telefone, @Item, @Data)";


            //PARAMETROS
            cmd.Parameters.AddWithValue("@Pessoa", Pessoa);
            cmd.Parameters.AddWithValue("@Telefone", Telefone);
            cmd.Parameters.AddWithValue("@Item", Item);
            cmd.Parameters.AddWithValue("@Data", Data);



            //CONECTAR COM BANCO -- Classe Conexao
            try
            {
                cmd.Connection = conexao.conectar();

                //EXECUTAR COMANDO
                cmd.ExecuteNonQuery();

                //DESCONECTAR
                conexao.desconectar();

                //MOSTRAR MENSAGEM
                this.result = true;
            }
            catch (SqlException)
            {
                this.result = false;
            }



        }

    }
}