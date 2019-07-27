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
        public static void VerificaUsuario(String nome, String senha)
        {

            VerificaUsuario(nome, senha);
            
        }

    }

}