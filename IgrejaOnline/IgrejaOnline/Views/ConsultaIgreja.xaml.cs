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
    /// Lógica interna para ConsultaIgreja.xaml
    /// </summary>
    public partial class ConsultaIgreja : Window
    {
        public ConsultaIgreja()
        {
            InitializeComponent();
        }

        private void GridListIgrejas_Loaded(object sender, RoutedEventArgs e)
        {
            Controllers.IgrejaController ic = new Controllers.IgrejaController();
            GridListIgrejas.ItemsSource = ic.ListarTodasIgrejas();
        }

        private void editarIgreja_Click(object sender, RoutedEventArgs e)
        {

            Modelos.Igrejas igrejaSelecionada = (Modelos.Igrejas)GridListIgrejas.SelectedItem;
            Controllers.IgrejaController ic = new Controllers.IgrejaController();
            EditarNewIgreja newEdit = new EditarNewIgreja();

            newEdit.boxID.Text = igrejaSelecionada.Id.ToString();
            newEdit.boxNomeIgreja.Text = igrejaSelecionada.NomeIgreja;
            newEdit.boxEnd.Text = igrejaSelecionada.EnderecoIgreja;
            newEdit.boxNumIgreja.Text = igrejaSelecionada.NumeroIgreja.ToString();
            newEdit.boxBairroIgreja.Text = igrejaSelecionada.BairroIgreja;
            newEdit.boxUFIgreja.Text = igrejaSelecionada.UFIgreja;
            newEdit.boxCNPJ.Text = igrejaSelecionada.CNPJIgreja;
            newEdit.BoxSiteIgreja.Text = igrejaSelecionada.SiteIgreja;
            
            newEdit.Show();
            this.Close();

        }

        private void excluirIgreja_Click(object sender, RoutedEventArgs e)
        {
            Modelos.Igrejas igrejaSelecionada = (Modelos.Igrejas)GridListIgrejas.SelectedItem;
            Controllers.IgrejaController ic = new Controllers.IgrejaController();
            ic.Excluir(igrejaSelecionada.Id);
            MessageBox.Show("Igreja excluida com sucesso!");
            GridListIgrejas.ItemsSource = ic.ListarTodasIgrejas();

        }
    }
}
