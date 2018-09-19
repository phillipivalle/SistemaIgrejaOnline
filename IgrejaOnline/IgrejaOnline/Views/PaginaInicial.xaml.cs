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

        private void btnAniversariantes_Click(object sender, RoutedEventArgs e)
        {
            ListaAniversariantes ListNiver = new ListaAniversariantes();
            ListNiver.ShowDialog();
        }

        private void btnNewPastor_Click(object sender, RoutedEventArgs e)
        {
            CadastroPastor CadastrandoPastor = new CadastroPastor();
            CadastrandoPastor.ShowDialog();
        }

        private void btnConsultarPastor_Click(object sender, RoutedEventArgs e)
        {
            ConsultaPastor ListPastor = new ConsultaPastor();
            ListPastor.ShowDialog();
        }

        private void btnPastorEdit_Click(object sender, RoutedEventArgs e)
        {
            PastorEdit EditandoPastor = new PastorEdit();
            EditandoPastor.ShowDialog();
        }

        private void btnNewIgreja_Click(object sender, RoutedEventArgs e)
        {
            CadastroNewIgreja CadastrandoIgreja = new CadastroNewIgreja();
            CadastrandoIgreja.ShowDialog();
        }

        private void btnNewCulto_Click(object sender, RoutedEventArgs e)
        {
            NewCultoWPF NovoCulto = new NewCultoWPF();
            NovoCulto.ShowDialog();
        }

        private void ConsultarIgreja_Click(object sender, RoutedEventArgs e)
        {
            ConsultaIgreja ListIgreja = new ConsultaIgreja();
            ListIgreja.ShowDialog();
        }

        private void igrejaEdit_Click(object sender, RoutedEventArgs e)
        {
            EditarNewIgreja EditandoIgreja = new EditarNewIgreja();
            EditandoIgreja.ShowDialog();
        }

        private void igrejaDelete_Click(object sender, RoutedEventArgs e)
        {
            ExcluindoIgreja DeletandoIgrejas = new ExcluindoIgreja();
            DeletandoIgrejas.ShowDialog();
        }

        private void btnHorarioCulto_Click(object sender, RoutedEventArgs e)
        {
            WPFListHorarios ListaHorario = new WPFListHorarios();
            ListaHorario.ShowDialog();
        }

        private void btnSaldo_Click(object sender, RoutedEventArgs e)
        {
            SaldosWPF SaldoAtual = new SaldosWPF();
            SaldoAtual.ShowDialog();
        }

        private void btnCadastrarNovoUsuario_Click(object sender, RoutedEventArgs e)
        {
            NovoUsuarioWPF CadastroNewUsuario = new NovoUsuarioWPF();
            CadastroNewUsuario.ShowDialog();
        }

        private void btnEditarNovoUsuario_Click(object sender, RoutedEventArgs e)
        {
            EditUsuarioNew EditandoUsuario = new EditUsuarioNew();
            EditandoUsuario.ShowDialog();
        }

        private void btnUsuarioCadastrado_Click(object sender, RoutedEventArgs e)
        {
            UsuariosCadastros ListUsuariosCadastrados = new UsuariosCadastros();
            ListUsuariosCadastrados.ShowDialog();
        }

        private void btnFazendoDoacao_Click(object sender, RoutedEventArgs e)
        {
            DoacoesWPF Doacao = new DoacoesWPF();
            Doacao.ShowDialog();
        }
    }
}
