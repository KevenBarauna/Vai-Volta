using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Windows.Forms;
using VaieVolta.Models;

namespace VaieVolta.DAO
{
    public class UsuarioDAO
    {
        public void Adicionar(String nometxt, String senhatxt) // ADICIONAR SEMPRE COM O ID 5
        {
            int id = 5;//..MOCANDO ID 5
          
            var contexto = new VaieVoltaEntities();//..ENTITY

            try//..INSERIR NO BANCO DE DADOS
            {
            contexto.Database.ExecuteSqlCommand(@"Insert into TB_Usuario (id, nome, senha) Values({0},{1},{2})", id, nometxt, senhatxt);
            MessageBox.Show("Cadastro realizado com sucesso!");
            }catch(Exception e)
            {
                MessageBox.Show("Erro! (ID 5 MOCADO)" + e);
            }

            

        }

        public void Deletar(int id)//..DELETAR USUSARIO
        {
            var contexto = new VaieVoltaEntities();//..ENTITY
            contexto.Database.ExecuteSqlCommand(@"DELETE FROM TB_Usuario WHERE id={0}", id);//..DELETE SQL
            MessageBox.Show("Usuário apagado do banco de dados com sucesso!");//..MENSAGEM
        } 

        public String BuscarPorNome(String nometxt) //RETONAR O NOME DO USUARIO / SER FOR NULL NÃO ACHOU
        {//..EU REALEMNTE PRECISO DISSO? <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            String usuario = null;
            var contexto = new VaieVoltaEntities();
            var query = from u in contexto.TB_Usuario select u;

            foreach (var item in query)
            {
                if (nometxt == item.nome) return usuario=item.nome;
            }
            return usuario;
        }

        public UsuarioModel UsuarioLogado(String nometxt)
        {
            var usuariologado = new UsuarioModel();

            var contexto = new VaieVoltaEntities();//..Entity
            var query = from u in contexto.TB_Usuario select u;//..Select Entity

            foreach (var item in query)
            {
                if (nometxt == item.nome)
                {
                    usuariologado.Id = item.id;
                    usuariologado.Nome = item.nome;
                    return usuariologado;
                }
            }

            return usuariologado;
        }

    }
}