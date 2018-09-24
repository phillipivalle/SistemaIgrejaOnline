using Modelos;
using System;
using System.Collections.Generic;
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
            contexto.CultosSet.Add(h);
            contexto.SaveChanges();
        }

        public List<Cultos> ListarTodosCultos()
        {
            return contexto.CultosSet.ToList();
        }


       public Cultos BuscarPorNome(string nome)
        {
            return contexto.CultosSet.Find(nome);
        }

       public void Excluir(string nome)
        {
            Cultos dExcluir = BuscarPorNome(nome);

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
