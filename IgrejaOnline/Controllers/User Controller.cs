using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class User_Controller
    {
      
        public  void inserirUser(User d)
        {
            IgrejaBDContainer contexto = new IgrejaBDContainer();
            contexto.UserSet.Add(d);
            contexto.SaveChanges();
        }

       
      public  List<User> ListarTodosUser()
        {
            IgrejaBDContainer contexto = new IgrejaBDContainer();
            return contexto.UserSet.ToList();
        }

        

     public List<User> Acesso (string login, string senha)
        {
            IgrejaBDContainer contexto = new IgrejaBDContainer();
            var agora = from a in contexto.UserSet
                        where a.Login.Equals(login)
                        && a.Senha.Equals(senha)
                        select a;
            return contexto.UserSet.ToList();
        }



        User BuscarPorNome(string nome)
        {
            IgrejaBDContainer contexto = new IgrejaBDContainer();
            return contexto.UserSet.Find(nome);
        }


        void Excluir(string nome)
        {
            User dExcluir = BuscarPorNome(nome);

            if (dExcluir != null)
            {
                IgrejaBDContainer contexto = new IgrejaBDContainer();
                contexto.UserSet.Remove(dExcluir);
                contexto.SaveChanges();
            }
        }

        void Editar(string nome, User NovosDadosUser)
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
