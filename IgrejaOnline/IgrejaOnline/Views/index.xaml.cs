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
        
        public bool yesOrNot;
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            {
                
                Modelos.User QualUsu = new Modelos.User();
                Controllers.User_Controller uc = new Controllers.User_Controller();
                PaginaInicial page = new PaginaInicial();
                page.Show();
                //yesOrNot = uc.verificarLogin(boxUsuario.Text, BoxSenhaUsu.Password);
               //if ( yesOrNot == true)
               // {

               //     QualUsu = uc.BuscarPorLogin(boxUsuario.Text);
               //     if(QualUsu.Funcao == "adm")
               //     {
               //         PaginaInicial comeco = new PaginaInicial();
               //         comeco.Show();
               //     }
               //     else
               //     {
               //         if(QualUsu.Funcao == "tesoureiro")
               //         {
               //             PaginaInicialTesoureiro comeco = new PaginaInicialTesoureiro();
               //             comeco.ShowDialog();
               //         }
               //         else
               //         {
               //             if(QualUsu.Funcao == "gestorPessoas")
               //             {
               //                 PaginaInicialGestorDePessoas comeco = new PaginaInicialGestorDePessoas();
               //                 comeco.ShowDialog();
               //             }
               //             else
               //             {
               //                 if(QualUsu.Funcao == "admEventos")
               //                 {
               //                     PaginaInicialGestorEventos comeco = new PaginaInicialGestorEventos();
               //                     comeco.ShowDialog();
               //                 }
               //             }
               //         }
               //     }
                   
               // }
               // else
               // {
               //     MessageBox.Show("Login ou senha inválido!");
               // }
                
                

            }

        }
    }
}

        
   

