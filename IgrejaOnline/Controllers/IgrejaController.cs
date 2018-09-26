using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class IgrejaController
    {
        IgrejaBDContainer contexto = new IgrejaBDContainer();

        public void inserirIgreja(Igrejas f)
        {
            contexto.IgrejasSet.Add(f);
            contexto.SaveChanges();
        }

        public Igrejas pesquisaID(string nome)
        {
            var lista = from p in contexto.IgrejasSet
                        where p.NomeIgreja == nome
                        select p;
            return lista.FirstOrDefault();
        }

        public List<Igrejas> ListarTodasIgrejas()
        {
            return contexto.IgrejasSet.ToList();
        }

        public Igrejas BuscarPorNome(string nome)
        {
            return contexto.IgrejasSet.Find(nome);
        }


        public Igrejas BuscarID(int id)
        {
            return contexto.IgrejasSet.Find(id);
        }
        public void Excluir(int id)
        {
            Igrejas dExcluir = BuscarID(id);

            if (dExcluir != null)
            {
                contexto.IgrejasSet.Remove(dExcluir);
                contexto.SaveChanges();
            }
        }

   
        //    // LINQ (https://code.msdn.microsoft.com/101-LINQ-Samples-3fb9811b)

        //public Int16 pesquisaBosta(string nome)
        //{
        //    int k7 = from p in contexto.IgrejasSet
        //             where p.NomeIgreja == nome
                                 
        //}



        public List<string> PesquisaNome()
        {
            var lista = from ig in contexto.IgrejasSet
                        select ig.NomeIgreja;
            return lista.ToList();
        }


      
      //  public User PesquisaID(string nome) { 

      //var lista = from ig in contexto.IgrejasSet
      //    where ig.NomeIgreja == nome

      //                  select ig.Id;
      //      return lista.ToList();

      //  }



        public void Editar(int id, Igrejas NovosDadosIgrejas)
        {
            Igrejas IgrejasAntigo = BuscarID(id);

            if(IgrejasAntigo != null)
            {
                IgrejasAntigo.NomeIgreja = NovosDadosIgrejas.NomeIgreja;
                IgrejasAntigo.EnderecoIgreja = NovosDadosIgrejas.EnderecoIgreja;
                IgrejasAntigo.NumeroIgreja = NovosDadosIgrejas.NumeroIgreja;
                IgrejasAntigo.BairroIgreja = NovosDadosIgrejas.BairroIgreja;
                IgrejasAntigo.UFIgreja = NovosDadosIgrejas.UFIgreja;
                IgrejasAntigo.CNPJIgreja = NovosDadosIgrejas.CNPJIgreja;
                IgrejasAntigo.SiteIgreja = NovosDadosIgrejas.SiteIgreja;


                contexto.Entry(IgrejasAntigo).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

    }
}

