using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace IgrejaOnline.Views
{
    /// <summary>
    /// Lógica interna para index.xaml
    /// </summary>
    public partial class index : Window
    {
        public index()
        {
            InitializeComponent();
        }
        public string login, senha;
        public bool cont;
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            {
                PaginaInicial comeco = new PaginaInicial();
                comeco.Show();

                //    List<Modelos.User> ucList = new List<Modelos.User>();
                //    Modelos.User use = new Modelos.User();
                //    login = boxUsuario.Text;
                //    senha = BoxSenhaUsu.Password;
                //    foreach (var login in ucList)
                //    {
                //        if (use.Login == login)
                //        {
                //            foreach (var senha in ucList)
                //            {
                //                cont = true;
                //            }               
                //        }
                //        else
                //        {
                //            cont = false;
                //        }
                //        }
                //    }

                //if(cont == true)
                //{
                //    MessageBox.Show("Deuz é bão");
                //    PaginaInicial inicialPage = new PaginaInicial();
                //    inicialPage.Show();
                //}
                //else
                //{
                //    MessageBox.Show("Falha no engano");
                //}
                //    Controllers.User_Controller uc = new Controllers.User_Controller();
                //    //if (uc.VerificarLogin(login, senha))
                //    //{
                //    //    MessageBox.Show("Alo diabo");
                //    //}
                //    //else
                //    //{
                //    //    MessageBox.Show("Alo gzus");
                //    //}
                //    //}


            }

        }
    }
}

        
   

