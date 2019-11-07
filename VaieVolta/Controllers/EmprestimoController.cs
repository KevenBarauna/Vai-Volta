using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Windows.Forms;
using VaieVolta.DAO;

namespace VaieVolta.Controllers
{
    public class EmprestimoController : Controller
    {
        public ActionResult NovoEmprestimo()//VAZIO - ABRIR PÁGINA PARA CADASTRAR UM NOVO EMPRESTIMO
        {
            return View();
        }
        public ActionResult CriarNovoEmprestimo(String idtxt, String objetotxt, String pessoatxt, String telefonetxt, String datadevolucaotxt, String dataemprestimotxt)//..SALVAR DADOS DE EMPRESTIMO NO BANCO
        {
            int id = Convert.ToInt32(idtxt);//..CONVERTE O VALOR DE IDTXT PARA INTEIRO

            EmprestimoDAO dao = new EmprestimoDAO();//..INSTANCIANDO OBJ BANCO
            dao.Adicionar(id, objetotxt, pessoatxt, telefonetxt, datadevolucaotxt, dataemprestimotxt);//..METODO ADICIONAR

            return RedirectToAction("Home", "Home");//..VOLTA PRA HOME
        }

    }
}