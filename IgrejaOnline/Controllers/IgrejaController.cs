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

   public     List<Igrejas> ListarTodasIgrejas()
        {
            return contexto.IgrejasSet.ToList();
        }

     public   Igrejas BuscarPorNome(string nome)
        {
            return contexto.IgrejasSet.Find(nome);
        }


     public void Excluir(string nome)
        {
            Igrejas dExcluir = BuscarPorNome(nome);

            if (dExcluir != null)
            {
                contexto.IgrejasSet.Remove(dExcluir);
                contexto.SaveChanges();
            }
        }


      public void Editar(string nome, Igrejas NovosDadosIgrejas)
        {
            Igrejas IgrejasAntigo = BuscarPorNome(nome);

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
