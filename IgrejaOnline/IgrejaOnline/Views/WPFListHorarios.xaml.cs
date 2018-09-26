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
    /// Lógica interna para WPFListHorarios.xaml
    /// </summary>
    public partial class WPFListHorarios : Window
    {
        public WPFListHorarios()
        {
            InitializeComponent();
        }

        private void GridListCultos_Loaded(object sender, RoutedEventArgs e)
        {
            Controllers.CultoController cc = new Controllers.CultoController();

            GridListCultos.ItemsSource = cc.ListarTodosCultos();

        }

        private void editarCulto_Click(object sender, RoutedEventArgs e)
        {
            Modelos.Cultos cultoSelecionado = (Modelos.Cultos)GridListCultos.SelectedItem;
            

        }

        private void excluirCulto_Click(object sender, RoutedEventArgs e)
        {
            Modelos.Cultos cultoSelecionado = (Modelos.Cultos)GridListCultos.SelectedItem;
            Controllers.CultoController cc = new Controllers.CultoController();
            cc.Excluir(cultoSelecionado.Id);
            MessageBox.Show("Culto excluído!");
            GridListCultos.ItemsSource = cc.ListarTodosCultos();
        }
    }
}
