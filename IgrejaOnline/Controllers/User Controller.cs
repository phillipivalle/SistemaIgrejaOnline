using Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class User_Controller
    {

        public void inserirUser(User d)
        {
            IgrejaBDContainer contexto = new IgrejaBDContainer();
            contexto.UserSet.Add(d);
            contexto.SaveChanges();
        }


        public List<User> ListarTodosUser()
        {
            IgrejaBDContainer contexto = new IgrejaBDContainer();
            return contexto.UserSet.ToList();
        }

        User BuscarPorNome(string nome)
        {
            IgrejaBDContainer contexto = new IgrejaBDContainer();
            return contexto.UserSet.Find(nome);
        }

        User BuscarLogin(String login)
        {
            IgrejaBDContainer contexto = new IgrejaBDContainer();
            return contexto.UserSet.Find(login);
        }

        //public bool VerificarLogin(string login, string senha)
        //{
        //    IgrejaBDContainer contexto = new IgrejaBDContainer();
        //    SqlCommand sql = new SqlCommand("select * from UserSet WHERE login = '" + login + "' AND senha = '" + senha + "' ");
        //    sql.CommandType = CommandType.Text;
        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    adapter.SelectCommand = sql;
        //    DataSet dataset = new DataSet();
        //    adapter.Fill(dataset);

        //    if (dataset.Tables[0].Rows.Count > 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}


      public  void Excluir(string login)
        {
            User dExcluir = BuscarLogin(login);

            if (dExcluir != null)
            {
                IgrejaBDContainer contexto = new IgrejaBDContainer();
                contexto.UserSet.Remove(dExcluir);
                contexto.SaveChanges();
            }
        }

       public void Editar(string nome, User NovosDadosUser)
        {
            User UserAntigo = BuscarPorNome(nome);

            if (UserAntigo != null)
            {

                UserAntigo.Nome = NovosDadosUser.Nome;
                UserAntigo.Senha = NovosDadosUser.Senha;
                UserAntigo.Funcao = NovosDadosUser.Funcao;
                UserAntigo.Email = NovosDadosUser.Email;
                
                IgrejaBDContainer contexto = new IgrejaBDContainer();

                contexto.Entry(UserAntigo).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }


    }
}
