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
        public string fun;
        public bool yesOrNot;
        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            {
                Modelos.User QualUsu = new Modelos.User();
                Controllers.User_Controller uc = new Controllers.User_Controller();
           
                yesOrNot = uc.verificarLogin(boxUsuario.Text, BoxSenhaUsu.Password);
                fun = uc.buscaFuncao(boxUsuario.Text);

                if (yesOrNot == true)
                {
                    PaginaInicial pag1 = new PaginaInicial();
                    pag1.Show();
                }
                }

            }
        }
    }

            








