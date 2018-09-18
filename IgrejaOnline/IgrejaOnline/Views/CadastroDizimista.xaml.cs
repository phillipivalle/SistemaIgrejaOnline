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
    /// Lógica interna para CadastroDizimista.xaml
    /// </summary>
    public partial class CadastroDizimista : Window
    {
        private string sexoTemp;
        private string bandeiraTemp;
        public CadastroDizimista()
        {
            InitializeComponent();
        }

        private void btnCadastrarNewDizimista_Click(object sender, RoutedEventArgs e)
        {
            // instância do dizimistra Controller "DC";
            Controllers.DizimistaController dc = new Controllers.DizimistaController();
            // instância do dizimista que irá receber os valores "fiel";
            Modelos.Dizimistas fiel = new Modelos.Dizimistas();


            string nu = boxN.ToString();
            string temp = DataNascimento.ToString();

            fiel.Nome = boxNome.Text;
            fiel.CPF = boxCpf.Text;
            
            fiel.Sexo = sexoTemp;
            fiel.Endereco = boxEnd.ToString();
            fiel.Numero = Convert.ToInt32(nu);
            fiel.Bairro = boxBairro.ToString();
            fiel.DataNasci = Convert.ToDateTime(temp);
            fiel.CEP = boxCEP.ToString();
            fiel.Cidade = boxCidade.ToString();
            fiel.UF = boxUF.ToString();
            fiel.NCartao = boxNumCartao.ToString();
            fiel.Validade = Convert.ToDateTime(boxValidade);
            fiel.Salario = Convert.ToDecimal(boxSalario);
            fiel.NomeImpresso = boxNomeCard.ToString();
            fiel.Bandeira = bandeiraTemp;

            dc.inserirDizimista(fiel);
        }

        private void radioFem_Checked(object sender, RoutedEventArgs e)
        {
            sexoTemp = "F";
        }

        private void radioMasc_Checked(object sender, RoutedEventArgs e)
        {
            sexoTemp = "M";
        }

        private void radioMaster_Checked(object sender, RoutedEventArgs e)
        {
            bandeiraTemp = "MasterCard";
        }

        private void radioVisa_Checked(object sender, RoutedEventArgs e)
        {
            bandeiraTemp = "Visa";
        }

        private void radioAmex_Checked(object sender, RoutedEventArgs e)
        {
            bandeiraTemp = "American Express";
        }
    }
}
