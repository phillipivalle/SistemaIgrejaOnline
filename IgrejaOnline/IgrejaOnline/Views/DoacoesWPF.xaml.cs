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
    /// Lógica interna para DoacoesWPF.xaml
    /// </summary>
    public partial class DoacoesWPF : Window
    {
        public DoacoesWPF()
        {
            InitializeComponent();
        }
        public string valorTot;
        private void btnDoacao_Click(object sender, RoutedEventArgs e)
        {
            Controllers.FinanceiroController fc = new Controllers.FinanceiroController();
            Controllers.DizimistaController dc = new Controllers.DizimistaController();
            Controllers.IgrejaController ic = new Controllers.IgrejaController();


            Modelos.Financeiro doacao = new Modelos.Financeiro();
            Modelos.Dizimistas dm = dc.pesquisandoID(dizimistaSelect.SelectedValue.ToString());
            Modelos.Igrejas im = ic.pesquisaID(IgrejaSelect.SelectedValue.ToString());
            valorTot = valorTot + Convert.ToDouble(ValorBox.Text);
            doacao.SaldoTot = valorTot.ToString();
            doacao.ValorDoado = ValorBox.Text;
            doacao.DizimistaDoador = dm.Nome;
            doacao.IgrejaBeneficiada = im.NomeIgreja;
            doacao.Dizimistas = dm;
            doacao.Igrejas = im;
            valorTot = valorTot + ValorBox;
            fc.inserir(doacao);
            MessageBox.Show("Valor doado!");

            







        }

     

        private void IgrejaSelect_Loaded_1(object sender, RoutedEventArgs e)
        {

            Controllers.IgrejaController ic = new Controllers.IgrejaController();
            IgrejaSelect.ItemsSource = ic.PesquisaNome();
        }

        private void dizimistaSelect_Loaded_1(object sender, RoutedEventArgs e)
        {
            Controllers.DizimistaController dc = new Controllers.DizimistaController();
            dizimistaSelect.ItemsSource = dc.PesquisaNome();
        }

        private void GridListDizimista_Loaded(object sender, RoutedEventArgs e)
        {
            Controllers.FinanceiroController fc = new Controllers.FinanceiroController();
            GridListDoacao.ItemsSource = fc.ListarTodoFinanceiro();
        }

   
    }
}
