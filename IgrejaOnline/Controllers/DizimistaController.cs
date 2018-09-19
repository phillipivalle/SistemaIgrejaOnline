using Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{

    public class DizimistaController
    {

        public void inserirDizimista(Dizimistas fiel)
        {
             IgrejaBDContainer contexto = new IgrejaBDContainer();
    
            {
                contexto.DizimistasSet.Add(fiel);
                contexto.SaveChanges();

            }
        }

       public List<Dizimistas> ListarTodosDizimistas()
        {
            IgrejaBDContainer contexto = new IgrejaBDContainer();
            return contexto.DizimistasSet.ToList();
        }

        List<Dizimistas> ListarDizimistasHomens(String sexom)
        {
            IgrejaBDContainer contexto = new IgrejaBDContainer();

            return contexto.DizimistasSet.ToList();
        }

        List<Dizimistas> ListarDizimistasMulheres(string sexo)
        {
            IgrejaBDContainer contexto = new IgrejaBDContainer();
            var lista = from d in contexto.DizimistasSet
                        where d.Sexo == "M"
                        select d;
            return lista.ToList();
        }

        List<Dizimistas> ListarDizimistasCrianca(int DataNasc)
        {
            DateTime hj = DateTime.Now;

            IgrejaBDContainer contexto = new IgrejaBDContainer();
            var lista = from d in contexto.DizimistasSet
                        where d.DataNasci < hj.AddYears(-12)
                        select d;
            return lista.ToList();
        }


        Dizimistas BuscarPorNome(string nome)
        {
            IgrejaBDContainer contexto = new IgrejaBDContainer();
            return contexto.DizimistasSet.Find(nome);
        }

        void Excluir(string nome)
        {
            Dizimistas dExcluir = BuscarPorNome(nome);

            if (dExcluir != null)
            {
                IgrejaBDContainer contexto = new IgrejaBDContainer();
                contexto.DizimistasSet.Remove(dExcluir);
                contexto.SaveChanges();
            }
        }

        void Editar(string nome, Dizimistas NovosDadosDizimista)
        {
            Dizimistas DizimistaAntigo = BuscarPorNome(nome);

            if (DizimistaAntigo != null)
            {

                DizimistaAntigo.Nome = NovosDadosDizimista.Nome;
                DizimistaAntigo.CPF = NovosDadosDizimista.CPF;
                DizimistaAntigo.Sexo = NovosDadosDizimista.Sexo;
                DizimistaAntigo.DataNasci = NovosDadosDizimista.DataNasci;
                DizimistaAntigo.Endereco = NovosDadosDizimista.Endereco;
                DizimistaAntigo.Numero = NovosDadosDizimista.Numero;
                DizimistaAntigo.Bairro = NovosDadosDizimista.Bairro;
                DizimistaAntigo.CEP = NovosDadosDizimista.CEP;
                DizimistaAntigo.Cidade = NovosDadosDizimista.Cidade;
                DizimistaAntigo.UF = NovosDadosDizimista.UF;
                DizimistaAntigo.NCartao = NovosDadosDizimista.NCartao;
                DizimistaAntigo.Validade = NovosDadosDizimista.Validade;
                DizimistaAntigo.CodSeguranca = NovosDadosDizimista.CodSeguranca;
                DizimistaAntigo.Salario = NovosDadosDizimista.Salario;
                DizimistaAntigo.NomeImpresso = NovosDadosDizimista.NomeImpresso;
                DizimistaAntigo.Bandeira = NovosDadosDizimista.Bandeira;

                IgrejaBDContainer contexto = new IgrejaBDContainer();

                contexto.Entry(DizimistaAntigo).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }
    }

}