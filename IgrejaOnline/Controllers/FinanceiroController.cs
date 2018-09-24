using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
   public class FinanceiroController
    {
        IgrejaBDContainer contexto = new IgrejaBDContainer();

      
       public void inserir(Financeiro g)
        {
            contexto.FinanceiroSet.Add(g);
            contexto.SaveChanges();
        }


     public   List<Financeiro> ListarTodoFinanceiro()
        {
            return contexto.FinanceiroSet.ToList();
        }

      public  Financeiro BuscarPorNome(string nome)
        {
            return contexto.FinanceiroSet.Find(nome);
        }


        public Financeiro buscarID(int id)
        {
            return contexto.FinanceiroSet.Find(id);
        }


     public   void Excluir(int id)
        {
            Financeiro dExcluir = buscarID(id);

            if (dExcluir != null)
            {
                contexto.FinanceiroSet.Remove(dExcluir);
                contexto.SaveChanges();
            }
        }



    }
}
