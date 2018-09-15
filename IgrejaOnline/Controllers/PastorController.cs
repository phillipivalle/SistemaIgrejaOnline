using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    class PastorController
    {
        void inserirPastor(Pastores e)
        {
            Modelos.IgrejaBDContainer contexto = new IgrejaBDContainer();
            contexto.PastoresSet.Add(e);
            contexto.SaveChanges();
        }

        List<Pastores> ListarTodosPastores()
        {
            Modelos.IgrejaBDContainer contexto = new IgrejaBDContainer();
            return contexto.PastoresSet.ToList();
        }

        Pastores BuscarPorNome(string nome)
        {
            IgrejaBDContainer contexto = new IgrejaBDContainer();
            return contexto.PastoresSet.Find(nome);
        }

        void Excluir (string nome)
        {
            Pastores eExcluir = BuscarPorNome(nome);

            if(dExcluir != null)
            {
                IgrejaBDContainer contexto = new IgrejaBDContainer();
                contexto.DizimistasSet.Remove(dExcluir);
                contexto.SaveChanges();
            }
        }

        void Editar (string nome, Pastores NovosDadosPastores)
        {
            Pastores PastoresAntigo = BuscarPorNome(nome);

            if(PastoresAntigo != null)
            {
                PastoresAntigo.Nome = NovosDadosPastores.Nome;
                PastoresAntigo.PastorCPF = NovosDadosPastores.PastorCPF;
                PastoresAntigo.PastorSexo = NovosDadosPastores.PastorSexo;
                PastoresAntigo.DataNascPastor = NovosDadosPastores.DataNascPastor;
                PastoresAntigo.EnderecoPastor = NovosDadosPastores.EnderecoPastor;
                PastoresAntigo.NumeroPastor = NovosDadosPastores.NumeroPastor;
                PastoresAntigo.CEPPastor = NovosDadosPastores.CEPPastor;
                PastoresAntigo.BairroPastor = NovosDadosPastores.BairroPastor;
                PastoresAntigo.CidadePastor = NovosDadosPastores.CidadePastor;
                PastoresAntigo.UFPastor = NovosDadosPastores.UFPastor;

                IgrejaBDContainer contexto = new IgrejaBDContainer();

                contexto.Entry(PastoresAntigo).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges(); 
            }

        }    
    

    }
}
