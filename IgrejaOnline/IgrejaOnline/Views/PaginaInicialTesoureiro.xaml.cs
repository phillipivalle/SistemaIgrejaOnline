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
    /// Lógica interna para PaginaInicialTesoureiro.xaml
    /// </summary>
    public partial class PaginaInicialTesoureiro : Window
    {
        public PaginaInicialTesoureiro()
        {
            InitializeComponent();
        }



        private void btnFazendoDoacao_Click(object sender, RoutedEventArgs e)
        {
            DoacoesWPF doacaoTesoureiro = new DoacoesWPF();
            doacaoTesoureiro.ShowDialog();
        }

        private void btnSaldo_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
