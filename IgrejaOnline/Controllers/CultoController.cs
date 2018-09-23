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
        IgrejaBDContainer contexto = new IgrejaBDContainer();

        void inserirCulto(Cultos h)
        {
            contexto.CultosSet.Add(h);
            contexto.SaveChanges();
        }

        List<Cultos> ListarTodosCultos()
        {
            return contexto.CultosSet.ToList();
        }


        Cultos BuscarPorNome(string nome)
        {
            return contexto.CultosSet.Find(nome);
        }

        void Excluir(string nome)
        {
            Cultos dExcluir = BuscarPorNome(nome);

            if (dExcluir != null)
            {
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



                contexto.Entry(CultoAntigo).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }



    }
}
