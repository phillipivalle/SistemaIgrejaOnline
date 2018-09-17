using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    internal class User_Controller
    {
        void inserirUser(User d)
        {
            IgrejaBDContainer contexto = new IgrejaBDContainer();
            contexto.UserSet.Add(d);
            contexto.SaveChanges();
        }

       
        List<User> ListarTodosUser()
        {
            IgrejaBDContainer contexto = new IgrejaBDContainer();
            return contexto.UserSet.ToList();
        }

        User BuscarLoginSenha(string nome, string senha)
        {
            IgrejaBDContainer contexto = new IgrejaBDContainer();

            return contexto.UserSet.Find(nome, senha);
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
