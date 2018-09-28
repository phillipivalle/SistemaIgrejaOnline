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
    public class User_Controller : BaseController
    {
        //variavel conferindo senha e login
        //
        bool senhaSim, loginSim;
        

        public bool verificarLogin(string log, string senha)
        {
            var login = from l in contexto.UserSet
                        where l.Login == log
                        select l;

            var senh = from s in contexto.UserSet
                       where s.Senha == senha
                       select s;

            if (login.ToList().Count > 0)
            {
                loginSim = true;
            }
            if (senh.ToList().Count > 0)
            {
                senhaSim = true;
            }
            if (loginSim && senhaSim)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void inserirUser(User d)
        {
            contexto.UserSet.Add(d);
            contexto.SaveChanges();
        }
        
        public User buscaFuncao (string login)
        {
            var temp = from d in contexto.UserSet
                       where d.Login == login

                       select d;
           
            return temp.FirstOrDefault();
        }


        public List<User> ListarTodosUser()
        {
            return contexto.UserSet.ToList();
        }

        public User BuscarPorNome(string nome)
        {
            return contexto.UserSet.Find(nome);
        }

        public User BuscarPorLogin(string login)
        {

            return contexto.UserSet.Find(login);
        }

        public User BuscarId(int id)
        {
            return contexto.UserSet.Find(id);
        }

        public void Excluir(User usuario)
        {
            User dExcluir = BuscarId(usuario.Id);
            if (dExcluir != null)
            {
                contexto.UserSet.Remove(dExcluir);

                contexto.SaveChanges();

            }
        }

        public void Editar(int id, User NovosDadosUser)
        {
            User UserAntigo = BuscarId(id);

            if (UserAntigo != null)
            {
                UserAntigo.Login = NovosDadosUser.Login;
                UserAntigo.Nome = NovosDadosUser.Nome;
                UserAntigo.Senha = NovosDadosUser.Senha;
                UserAntigo.Funcao = NovosDadosUser.Funcao;
                UserAntigo.Email = NovosDadosUser.Email;

                
                contexto.Entry(UserAntigo).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }


    }
}
