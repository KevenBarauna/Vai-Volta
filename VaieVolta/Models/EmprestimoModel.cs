using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VaieVolta.Models
{
    public class EmprestimoModel
    {
        public int Id { get; set; }
        public String Pessoa { get; set; }
        public String Objeto { get; set; }
        public String DataEmprestimo { get; set; }
        public String DataDevolucao { get; set; }
        public String Telefone { get; set; }
    }
}