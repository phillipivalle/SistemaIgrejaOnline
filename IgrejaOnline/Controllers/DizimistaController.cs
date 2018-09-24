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
        IgrejaBDContainer contexto = new IgrejaBDContainer();

        public void inserirDizimista(Dizimistas fiel)
        {
    
            {
                contexto.DizimistasSet.Add(fiel);
                
                contexto.SaveChanges();

            }
        }

     public List<Dizimistas> ListarTodosDizimistas()
        {
            return contexto.DizimistasSet.ToList();
        }

     public   List<Dizimistas> ListarDizimistasSexo(String sexom)
        {
            var listM = from m in contexto.DizimistasSet
                        where m.Sexo == sexom
                        select m;
            return listM.ToList();
        }

        //public List<Dizimistas> listDizimistaIdade(DateTime date)
        //{
        //    var data = from d in contexto.DizimistasSet
        //               where d.DataNasci == date
        //               select d;

        //    return data;
        //}


     public  List<Dizimistas> ListarDizimistasMulheres(string sexo)
        {
            var lista = from d in contexto.DizimistasSet
                        where d.Sexo == "M"
                        select d;
            return lista.ToList();
        }

      public  List<Dizimistas> ListarDizimistasCrianca(int DataNasc)
        {
            DateTime hj = DateTime.Now;

            var lista = from d in contexto.DizimistasSet
                        where d.DataNasci < hj.AddYears(-12)
                        select d;
            return lista.ToList();
        }


       public Dizimistas BuscarPorNome(string nome)
        {
            return contexto.DizimistasSet.Find(nome);
        }

        public Dizimistas BuscarID(int id)
        {
            return contexto.DizimistasSet.Find(id);
        }

      public  void Excluir(int id)
        {
            Dizimistas dExcluir = BuscarID(id);

            if (dExcluir != null)
            {
                contexto.DizimistasSet.Remove(dExcluir);
                contexto.SaveChanges();
            }
        }

       public void Editar(int id, Dizimistas NovosDadosDizimista)
        {
            Dizimistas DizimistaAntigo = BuscarID(id);

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


                contexto.Entry(DizimistaAntigo).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }
    }

}