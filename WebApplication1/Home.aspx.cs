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
        private static List<Pessoa> pessoa = new List<Pessoa>();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        [System.Web.Services.WebMethod]
        public static string BuscaNome(String nome, String email, String senha)
        {  
            pessoa.Add(new Pessoa(nome, email));

            // return "Seu nome é " + nome.ToString();
            return "Seu nome: " + nome.ToString() + ", Seu E-mail: " + email.ToString() + " Sua senha: " + senha.ToString();
        }

    }
}