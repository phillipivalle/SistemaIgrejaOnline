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
    /// Lógica interna para EditarDizimista.xaml
    /// </summary>
    public partial class EditarDizimista : Window
    {
      public  string sexo;
       public string bandeira;
        public EditarDizimista()
        {
            InitializeComponent();
        }

        private void radioFem_Checked(object sender, RoutedEventArgs e)
        {
            sexo = "F";
        }

        private void radioMasc_Checked(object sender, RoutedEventArgs e)
        {
            sexo = "M";
        }

        private void Master_Checked(object sender, RoutedEventArgs e)
        {
            bandeira = "MasterCard";
        }

        private void radioVisa_Checked(object sender, RoutedEventArgs e)
        {
            bandeira = "Visa";
        }

        private void Amex_Checked(object sender, RoutedEventArgs e)
        {
            bandeira = "American Express";
        }

        private void btnCadastrarNewDizimista_Click(object sender, RoutedEventArgs e)
        {
            Controllers.DizimistaController dc = new Controllers.DizimistaController();
            Modelos.Dizimistas newDizimista = new Modelos.Dizimistas();
            ConsultaDizimista att = new ConsultaDizimista();

            newDizimista.Id = Convert.ToInt16(boxID.Text);
            newDizimista.Nome = boxNome.Text;
            newDizimista.CPF = boxCpf.Text;
            newDizimista.Sexo = sexo;
            newDizimista.DataNasci = Convert.ToDateTime(BoxDataNascimento.Text);
            newDizimista.Endereco = boxEnd.Text;
            newDizimista.Numero = Convert.ToInt16(boxNum.Text);
            newDizimista.Bairro = boxBairro.Text;
            newDizimista.CEP = boxCEP.Text;
            newDizimista.Cidade = boxCidade.Text;
            newDizimista.UF = boxUF.Text;
            newDizimista.NCartao = boxNumCartao.Text;
            newDizimista.Validade = Convert.ToDateTime(boxValidade.Text);
            newDizimista.CodSeguranca = boxSeguranca.Text;
            newDizimista.Salario = Convert.ToDecimal(boxSalario.Text);
            newDizimista.NomeImpresso = boxNomeCard.Text;
            newDizimista.Bandeira = bandeira;

            dc.Editar(newDizimista.Id, newDizimista);
            MessageBox.Show("Editado com sucesso!!!");
            this.Close();
            att.GridListDizimista.ItemsSource = dc.ListarTodosDizimistas();
            att.ShowDialog();

        }
    }
}
