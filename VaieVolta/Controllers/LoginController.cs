using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VaieVolta.DAO;
using VaieVolta.Controllers;
using VaieVolta.Models;
using System.Windows.Forms;

namespace VaieVolta.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Login()//..PÁGINA DE LOGIN
        {
            return View();
        }

        public ActionResult Autentica(string nometxt, string senhatxt)//..VERIFICA SE SENHA E USUARIO ESTÃO CORRETOS 
        {
            //.....VERIFICA SE USUARIO JÁ EXISTE....\\
            var contexto = new VaieVoltaEntities();//..ENTITY
            var query = from u in contexto.TB_Usuario select u;//..SELECT ENTNTY
            var usuarioLogado = new UsuarioModel();//..Criando um novo usario para pegar informações dele
            foreach (var item in query)
            {
                if (nometxt == item.nome && senhatxt == item.senha)// ..VERIFICA SE SENHA E USUARIO ESTÃO CORRETOS
                {
                    //var dao = new UsuarioDAO();//..INSTANCIANDO USUARIO DAO
                    //var usuariologado = new UsuarioModel();//..CRIANDO UMA VÁRIAVEL PARA GUARDAR OS DADOS DO USÁRIO LOGADO
                    //usuariologado = dao.UsuarioLogado(nometxt);//GUARDANDO DADOS DO USUARIO LOGADO

                    MessageBox.Show("Bem-Vindo(a)!");//..MENSAGEM
                    return RedirectToAction("Home", "Home");//..VAI PRA HOME
                }
            }
            MessageBox.Show("Esse usuário não existe");//..MENSAGEM CASO NÃO ACHE USUÁRIO
            return RedirectToAction("Login", "Login");//..VOLTA PRO LOGIN
        }

        public ActionResult CadastrarConta()//..PÁGINA DE NOVO USUÁRIO
        {
            return View();
        }

        public ActionResult CriarConta(String nometxt, String senhatxt)//..CRIAR UMA NOVA CONTA
        {
            //.....VERIFICA SE O NOME USUARIO JÁ ESTA EM USO....\\
            var contexto = new VaieVoltaEntities();//..ENTITY
            var query = from u in contexto.TB_Usuario select u;//..SELECT ENTITY

            foreach (var item in query)
            {
                if (nometxt == item.nome)//..SE NOME DIGITADO ESTÁ NO BANCO
                {
                    MessageBox.Show("Esse nome de usuário já existe");//..MENSAGEM
                        return RedirectToAction("CadastrarConta", "Login");//..CONTINUA NO LIGIN
                }
            }
            //.....CASO CONSIGA USAR O NOME....\\
            UsuarioDAO dao = new UsuarioDAO();//..ENTITY
            dao.Adicionar(nometxt,senhatxt);//..CHAMA METODO ADICIONAR

            return RedirectToAction("Home", "Home");//..VAI PRA HOME
        }

        public ActionResult ApagarConta(String idtxt)//..APAGAR CONTA POR ID
        {
            int id = Convert.ToInt32(idtxt);//..CONVERT ID EM INT
            UsuarioDAO dao = new UsuarioDAO();//..INSTANCIA OBJ DO BANCO
            dao.Deletar(id);//..CHAMMA O METODO DE DELETAR

            return RedirectToAction("Login", "Login");//..RETORNA PRO LOGIN
        }
    }
}