using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    class CultoController
    {
        void inserirCulto(Cultos h)
        {
            IgrejaBDContainer contexto = new IgrejaBDContainer();
            contexto.DizimistasSet.Add(h);
            contexto.SaveChanges();
        }

        List<Cultos> ListarTodosCultos()
        {
            IgrejaBDContainer contexto = new IgrejaBDContainer();
            return contexto.CultosSet.ToList();
        }


        Cultos BuscarPorNome(string nome)
        {
            IgrejaBDContainer contexto = new IgrejaBDContainer();
            return contexto.CultosSet.Find(nome);
        }

        void Excluir(string nome)
        {
            Cultos dExcluir = BuscarPorNome(nome);

            if (dExcluir != null)
            {
                IgrejaBDContainer contexto = new IgrejaBDContainer();
                contexto.CultosSet.Remove(dExcluir);
                contexto.SaveChanges();
            }
        }



        void Editar(string nome, Cultos NovosDadosCulto)
        {
            Cultos CultoAntigo = BuscarPorNome(nome);

            if (CultoAntigo != null)
            {

                CultoAntigo.DataCulto = NovosDadosCulto.DataCulto;
                CultoAntigo.HorarioCulto = NovosDadosCulto.HorarioCulto;
                CultoAntigo.LocalCulto = NovosDadosCulto.LocalCulto;           


                IgrejaBDContainer contexto = new IgrejaBDContainer();

                contexto.Entry(CultoAntigo).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }



    }
}
