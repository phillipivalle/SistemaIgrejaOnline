using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class PastorController
    {
        IgrejaBDContainer contexto = new IgrejaBDContainer();

        public void inserirPastor(Pastores e)
        {
            contexto.PastoresSet.Add(e);
            contexto.SaveChanges();
        }


        public string PesquisaID(string nome)
        {

            var lista = from past in contexto.PastoresSet
                        where past.Nome == nome

                        select past.Id;
            return lista.ToString();

        }



        public  List<Pastores> ListarTodosPastores()
        {
            return contexto.PastoresSet.ToList();
        }

     public  Pastores BuscarPorNome(string nome)
        {
            return contexto.PastoresSet.Find(nome);
        }

        public List<string> PesquisaNome()
        {
            var lista = from p in contexto.PastoresSet
                        select p.Nome;
            return lista.ToList();
        }
            public List<int> pesquisaID(string nome)
            {
                var lista = from p in contexto.PastoresSet
                            where p.Nome == nome
                            select p.Id;
                return lista.ToList();
            }
        

       public Pastores buscarID(int id)
        {
            return contexto.PastoresSet.Find(id);
        } 

       public void Excluir (int id)
        {
            Pastores dExcluir = buscarID(id);

            if(dExcluir != null)
            {
                contexto.PastoresSet.Remove(dExcluir);
                contexto.SaveChanges();
            }
        }

     public   void Editar (int id, Pastores NovosDadosPastores)
        {
            Pastores PastoresAntigo = buscarID(id);

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


                contexto.Entry(PastoresAntigo).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges(); 
            }

        }    
    

    }
}
