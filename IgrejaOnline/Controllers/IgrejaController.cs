using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    class IgrejaController
    {
        void inserirIgreja(Igrejas f)
        {
            IgrejaBDContainer contexto = new IgrejaBDContainer();
            contexto.IgrejasSet.Add(f);
            contexto.SaveChanges();
        }

        List<Igrejas> ListarTodasIgrejas()
        {
            IgrejaBDContainer contexto = new IgrejaBDContainer();
            return contexto.IgrejasSet.ToList();
        }

        Dizimistas BuscarPorNome(string nome)
        {
            IgrejaBDContainer contexto = new IgrejaBDContainer();
            return contexto.IgrejasSet.Find(nome);
        }


        void Excluir(string nome)
        {
            Igrejas dExcluir = BuscarPorNome(nome);

            if (dExcluir != null)
            {
                IgrejaBDContainer contexto = new IgrejaBDContainer();
                contexto.IgrejasSet.Remove(dExcluir);
                contexto.SaveChanges();
            }
        }


        void Editar(string nome, Igrejas NovosDadosIgrejas)
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

                IgrejaBDContainer contexto = new IgrejaBDContainer();

                contexto.Entry(IgrejasAntigo).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

    }
}
