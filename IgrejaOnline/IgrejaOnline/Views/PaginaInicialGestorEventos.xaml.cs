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
    /// Lógica interna para PaginaInicialGestorEventos.xaml
    /// </summary>
    public partial class PaginaInicialGestorEventos : Window
    {
        public PaginaInicialGestorEventos()
        {
            InitializeComponent();
        }

        private void btnNewIgreja_Click(object sender, RoutedEventArgs e)
        {
            CadastroNewIgreja CadastrandoNovaIgrejaGestor = new CadastroNewIgreja();
            CadastrandoNovaIgrejaGestor.ShowDialog();
        }

        private void ConsultarIgreja_Click(object sender, RoutedEventArgs e)
        {
            ConsultaIgreja consultarIgrejaGestor = new ConsultaIgreja();
            consultarIgrejaGestor.ShowDialog();
        }

        private void igrejaEdit_Click(object sender, RoutedEventArgs e)
        {
            EditarNewIgreja EditandoIgrejaGestor = new EditarNewIgreja();
            EditandoIgrejaGestor.ShowDialog();
        }

        private void igrejaDelete_Click(object sender, RoutedEventArgs e)
        {
            ExcluindoIgreja DeletandoIgrejaGestor = new ExcluindoIgreja();
            DeletandoIgrejaGestor.ShowDialog();
        }

        private void btnNewCulto_Click(object sender, RoutedEventArgs e)
        {
            NewCultoWPF NovoCultoGestor = new NewCultoWPF();
            NovoCultoGestor.ShowDialog();
        }

        private void btnHorarioCulto_Click(object sender, RoutedEventArgs e)
        {
            WPFListHorarios ListaHorariosGestor = new WPFListHorarios();
            ListaHorariosGestor.ShowDialog();
        }
    }
}
