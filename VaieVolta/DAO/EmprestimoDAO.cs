using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Forms;
using VaieVolta.Models;

namespace VaieVolta.DAO
{
    public class EmprestimoDAO
    {

        public void Adicionar(int idtxt, String objetotxt, String pessoatxt, String telefonetxt, String datadevolucaotxt, String dataemprestimotxt)//..ADICIONAR NOVO EMPRESTIMO
        {
            var contexto = new VaieVoltaEntities();//..ENTITY

            //..INSER NO BANCI..\\
            contexto.Database.ExecuteSqlCommand(@"Insert into TB_Emprestimo 
            (id, obejto, pessoa, telefone, datadevolucao, dataemprestimo) 
            Values({0},{1},{2},{3},{4},{5})", idtxt, objetotxt, pessoatxt, telefonetxt, datadevolucaotxt, dataemprestimotxt);

            MessageBox.Show("Cadastro de emprestimo realizado com sucesso!");//..MENSAGEM

        }

        public void Deletar(int id)
        {
           //FAZER
        }

        public List<EmprestimoModel> Listar() //..LISTAR TODOS OS EMPRESTIMMOS
        {
            List<EmprestimoModel> emprestimos = new List<EmprestimoModel>();//..CRIANDO LISTA DE EMPRESTIMOS

            var contexto = new VaieVoltaEntities();//..ENTITY

            var query = from e in contexto.TB_Emprestimo select e;//..SELECT DO ENTITY

            foreach (var item in query)
            {
                EmprestimoModel temp = new EmprestimoModel();//..CRIANDO UMA VÁRIAVEL TEMPORARIA PARA ARMAZENAR CADA VALOR CONTIDO NO BANCO
                temp.Id = item.id;
                temp.Objeto = item.obejto;
                temp.Pessoa = item.pessoa;
                temp.Telefone = item.telefone;
                temp.DataDevolucao = item.datadevolucao;
                temp.DataEmprestimo = item.dataemprestimo;
                emprestimos.Add(temp);//..ADICIONAR VARIAVEL TEMPORARIA NA LISTA
            }
            return emprestimos;//..RETORNA LISTA DE EMPESTIMOS
        }

    }
}