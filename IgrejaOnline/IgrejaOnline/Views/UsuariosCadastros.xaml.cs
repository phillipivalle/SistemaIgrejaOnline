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
    /// Lógica interna para UsuariosCadastros.xaml
    /// </summary>
    public partial class UsuariosCadastros : Window
    {


        public UsuariosCadastros()
        {
            InitializeComponent();
        }

        private void GridListDizimista_Loaded(object sender, RoutedEventArgs e)
        {
            Controllers.User_Controller uc = new Controllers.User_Controller();
            GridListDizimista.ItemsSource = uc.ListarTodosUser();
            
        }
        private string login;
        private void ExcluirUser_Click(object sender, RoutedEventArgs e)
        {
            Controllers.User_Controller uc = new Controllers.User_Controller();
            Modelos.User excluido = new Modelos.User();

            login = Convert.ToString(ColumLogin);
            
            uc.Excluir(excluido.Login);
            uc.ListarTodosUser();
        }
    }
    }
    

