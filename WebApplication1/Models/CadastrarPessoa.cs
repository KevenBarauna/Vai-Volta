using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class CadastrarPessoa
    {

        Conexao conexao = new Conexao();
        SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
        public String mensagem = "";
        public CadastrarPessoa(String Pessoa, String Email, String Senha)
        {
            //COMANDO SQL -- INSET  -- SqlCommand
            cmd.CommandText = "insert into pessoa (Pessoa, Email, Senha) values (@Pessoa, @Email, @Senha)";


            //PARAMETROS
            cmd.Parameters.AddWithValue("@Pessoa", Pessoa);
            cmd.Parameters.AddWithValue("@Telefone", Email);
            cmd.Parameters.AddWithValue("@Item", Senha);



            //CONECTAR COM BANCO -- Classe Conexao
            try
            {
                cmd.Connection = conexao.conectar();

                //EXECUTAR COMANDO
                cmd.ExecuteNonQuery();

                //DESCONECTAR
                conexao.desconectar();

                //MOSTRAR MENSAGEM
                this.mensagem = "Cadastrado com Sucesso!";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao cadastrar :/ " + e;
            }



        }

    }
}