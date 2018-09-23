using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    class FinanceiroController
    {
        IgrejaBDContainer contexto = new IgrejaBDContainer();

        void inserir(Financeiro g)
        {
            contexto.FinanceiroSet.Add(g);
            contexto.SaveChanges();
        }


        List<Financeiro> ListarTodoFinanceiro()
        {
            return contexto.FinanceiroSet.ToList();
        }

        Financeiro BuscarPorNome(string nome)
        {
            return contexto.FinanceiroSet.Find(nome);
        }

        void Excluir(string nome)
        {
            Financeiro dExcluir = BuscarPorNome(nome);

            if (dExcluir != null)
            {
                contexto.FinanceiroSet.Remove(dExcluir);
                contexto.SaveChanges();
            }
        }



    }
}
