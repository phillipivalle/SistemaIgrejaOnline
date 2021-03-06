﻿using Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers 
{

    public class DizimistaController : BaseController
    {
     

        //inserindo dizimistas no banco
        public void inserirDizimista(Dizimistas fiel)
        {
    
            
                contexto.DizimistasSet.Add(fiel);
                
                contexto.SaveChanges();

            
        }

    //listando todos dizimistas
     public List<Dizimistas> ListarTodosDizimistas()
        {
            return contexto.DizimistasSet.ToList();
        }


     //listando dizimistas por sexo
     public   List<Dizimistas> ListarDizimistasSexo(String sexom)
        {
            var listM = from m in contexto.DizimistasSet
                        where m.Sexo == sexom
                        select m;
            return listM.ToList();

        }

    //listando dizimistas crianças
      //public  List<Dizimistas> ListarDizimistasCrianca()
      //  {
      //      DateTime hj = DateTime.Now;

      //      int ano = hj.Year;

      //      var lista = from d in contexto.DizimistasSet
      //                  where 
      //                  select d;
      //      return lista.ToList();
      //  }

        //buscando por nome
       public Dizimistas BuscarPorNome(string nome)
        {
            return contexto.DizimistasSet.Find(nome);
        }


        public List<string> PesquisaNome()
        {
            var lista = from p in contexto.DizimistasSet
                        select p.Nome;
            return lista.ToList();
        }

        //buscando por id
        public Dizimistas BuscarID(int id)
        {

         return  contexto.DizimistasSet.Find(id);
        }

        public Dizimistas pesquisandoID(string nome)
        {
            var lista = from p in contexto.DizimistasSet
                        where p.Nome == nome
                        select p;
            return lista.FirstOrDefault();
        }
        //excluindo dizimista
      public  void Excluir(int id)
        {
            Dizimistas dExcluir = BuscarID(id);

            if (dExcluir != null)
            {
                contexto.DizimistasSet.Remove(dExcluir);
                contexto.SaveChanges();
            }
        }

        //editando dizimistas
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