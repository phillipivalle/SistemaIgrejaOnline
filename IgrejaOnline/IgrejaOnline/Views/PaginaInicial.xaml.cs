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
    /// Lógica interna para PaginaInicial.xaml
    /// </summary>
    public partial class PaginaInicial : Window
    {
        public PaginaInicial()
        {
            InitializeComponent();
        }

        private void btnNovoDizimista_Click(object sender, RoutedEventArgs e)
        {
            CadastroDizimista cadastrarFiel = new CadastroDizimista();

            cadastrarFiel.ShowDialog();
        }

        private void btnTotalDizimistas_Click(object sender, RoutedEventArgs e)
        {
            ConsultaDizimista ListDizimista = new ConsultaDizimista();

            ListDizimista.ShowDialog();
        }

        private void btnTotHomens_Click(object sender, RoutedEventArgs e)
        {
            ListaHomens ListHomensDizimistas = new ListaHomens();
            ListHomensDizimistas.ShowDialog();
        }

        private void btnTotMulheres_Click(object sender, RoutedEventArgs e)
        {
            ListaMulheres ListMulheresDizimistas = new ListaMulheres();
            ListMulheresDizimistas.ShowDialog();
        }

        private void FaixaCrianca_Click(object sender, RoutedEventArgs e)
        {
            ListaCrianças ListCrianca = new ListaCrianças();
            ListCrianca.ShowDialog();
        }

        private void FaixaAdolescente_Click(object sender, RoutedEventArgs e)
        {
            ListAdolescentes ListAdolescente = new ListAdolescentes();
            ListAdolescente.ShowDialog();
        }

        private void FaixaAdultos_Click(object sender, RoutedEventArgs e)
        {
            ListaAdultos ListAdultos = new ListaAdultos();
            ListAdultos.ShowDialog();
        }

        private void FaixaIdosos_Click(object sender, RoutedEventArgs e)
        {
            ListaIdosos ListIdosos = new ListaIdosos();
            ListIdosos.ShowDialog();
        }

        private void btnFielEdit_Click(object sender, RoutedEventArgs e)
        {
            EditarDizimista FielEdit = new EditarDizimista();
            FielEdit.ShowDialog();
        }

        private void btnFielDelete_Click(object sender, RoutedEventArgs e)
        {
            ExcluindoDizimista FielDelete = new ExcluindoDizimista();
            FielDelete.ShowDialog();
        }

        private void btnAniversariantes_Click(object sender, RoutedEventArgs e)
        {
            ListaAniversariantes ListNiver = new ListaAniversariantes();
            ListNiver.ShowDialog();
        }
    }
}
