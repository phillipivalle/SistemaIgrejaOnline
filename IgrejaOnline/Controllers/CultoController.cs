using Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
  public  class CultoController
    {
        IgrejaBDContainer contexto = new IgrejaBDContainer();


  public void inserirCulto(Cultos h)
        {
            IgrejaBDContainer insericult = new IgrejaBDContainer();

            insericult.CultosSet.Add(h);
            insericult.SaveChanges();
           
        }

        public List<Cultos> ListarTodosCultos()
        {
            return contexto.CultosSet.ToList();
        }


       public Cultos BuscarPorNome(string nome)
        {
            return contexto.CultosSet.Find(nome);
        }

        public Cultos BuscarID(int id)
        {
            return contexto.CultosSet.Find(id);
        }

       public void Excluir(int id)
        {
            Cultos dExcluir = BuscarID(id);

            if (dExcluir != null)
            {
                contexto.CultosSet.Remove(dExcluir);
                contexto.SaveChanges();
            }
        }



       public void Editar(string nome, Cultos NovosDadosCulto)
        {
            Cultos CultoAntigo = BuscarPorNome(nome);

            if (CultoAntigo != null)
            {

                CultoAntigo.DataCulto = NovosDadosCulto.DataCulto;
                CultoAntigo.HorarioCulto = NovosDadosCulto.HorarioCulto;
                CultoAntigo.LocalCulto = NovosDadosCulto.LocalCulto;           



                contexto.Entry(CultoAntigo).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }
    }
}
