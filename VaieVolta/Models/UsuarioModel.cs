using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VaieVolta.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Senha { get; set; }
        public List<EmprestimoModel> Emprestimo { get; set; }
    }
}