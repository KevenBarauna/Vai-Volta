using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Default : System.Web.UI.Page
    {

        [System.Web.Services.WebMethod]
        public static string BuscaNome(String nome, String email, String senha, String confsenha)
        {


            if (senha.ToString() != confsenha.ToString())
            {
                return "Senhas diferentes";
            }
            else
            if (senha.ToString() == confsenha.ToString())
            {
                CadastrarPessoa();
                return "Bem-vindo(a)" + nome.ToString();
                
            }
            else
            {
                return "Erro";
            }


        }

        private static void CadastrarPessoa()
        {
            throw new NotImplementedException();
        }
    }
}