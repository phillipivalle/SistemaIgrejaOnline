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

        private void btnDeposito_Click(object sender, RoutedEventArgs e)
        {
            DepositosWPF depositoTesoureiro = new DepositosWPF();
            depositoTesoureiro.ShowDialog();
        }

        private void btnCartao_Click(object sender, RoutedEventArgs e)
        {
            DoacaoCartaoWPF cartaoTesoureiroDoacao = new DoacaoCartaoWPF();
            cartaoTesoureiroDoacao.ShowDialog();
        }

        private void btnBoleto_Click(object sender, RoutedEventArgs e)
        {
            DoacaoBoletoWPF boletoDoacaoTesoureiro = new DoacaoBoletoWPF();
            boletoDoacaoTesoureiro.ShowDialog();
        }

        private void btnSaldo_Click(object sender, RoutedEventArgs e)
        {
            SaldosWPF SaldoTesoureiro = new SaldosWPF();
            SaldoTesoureiro.ShowDialog();
        }

        private void btnReceita_Click(object sender, RoutedEventArgs e)
        {
            ReceitaWPF receitaTesoureiro = new ReceitaWPF();
            receitaTesoureiro.ShowDialog();
        }

        private void btnDespesas_Click(object sender, RoutedEventArgs e)
        {
            DespesasWPF despesaTesoureiro = new DespesasWPF();
            despesaTesoureiro.ShowDialog();
        }
    }
}
