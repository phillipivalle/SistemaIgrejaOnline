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
        void inserir(Financeiro g)
        {
            IgrejaBDContainer contexto = new IgrejaBDContainer();
            contexto.FinanceiroSet.Add(g);
            contexto.SaveChanges();
        }


        List<Financeiro> ListarTodoFinanceiro()
        {
            IgrejaBDContainer contexto = new IgrejaBDContainer();
            return contexto.FinanceiroSet.ToList();
        }

        Financeiro BuscarPorNome(string nome)
        {
            IgrejaBDContainer contexto = new IgrejaBDContainer();
            return contexto.FinanceiroSet.Find(nome);
        }

        void Excluir(string nome)
        {
            Financeiro dExcluir = BuscarPorNome(nome);

            if (dExcluir != null)
            {
                IgrejaBDContainer contexto = new IgrejaBDContainer();
                contexto.FinanceiroSet.Remove(dExcluir);
                contexto.SaveChanges();
            }
        }



    }
}
