using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VaieVolta.DAO;

namespace VaieVolta.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Home()//..HOME
        {
            EmprestimoDAO dao = new EmprestimoDAO();//..INSTANCIANDO OBJ NO BANCO
            ViewBag.EmprestimoView = dao.Listar();//..LISTAR OS EMPRESTIMOS
            return View();//..RETORNA PRA VIEW
        }
    }
}