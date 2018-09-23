﻿using Modelos;
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

      public  List<Pastores> ListarTodosPastores()
        {
            return contexto.PastoresSet.ToList();
        }

        Pastores BuscarPorNome(string nome)
        {
            return contexto.PastoresSet.Find(nome);
        }

        void Excluir (string nome)
        {
            Pastores dExcluir = BuscarPorNome(nome);

            if(dExcluir != null)
            {
                contexto.PastoresSet.Remove(dExcluir);
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


                contexto.Entry(PastoresAntigo).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges(); 
            }

        }    
    

    }
}
