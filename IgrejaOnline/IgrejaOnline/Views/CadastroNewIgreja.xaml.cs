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
    /// Lógica interna para CadastroNewIgreja.xaml
    /// </summary>
    public partial class CadastroNewIgreja : Window
    {
        public CadastroNewIgreja()
        {
            InitializeComponent();
        }

        private void btnCadastrarNewPastor_Click(object sender, RoutedEventArgs e)
        {
            Controllers.IgrejaController ic = new Controllers.IgrejaController();
            Modelos.Igrejas ig = new Modelos.Igrejas();

            try
            {
                ig.NomeIgreja = boxNomeIgreja.Text;
                ig.EnderecoIgreja = boxNumIgreja.Text;
                ig.BairroIgreja = boxBairroIgreja.Text;
                ig.UFIgreja = boxUFIgreja.Text;
                ig.CNPJIgreja = boxCNPJ.Text;
                ig.SiteIgreja = BoxSiteIgreja.Text;

                ic.inserirIgreja(ig);
                MessageBox.Show("Igreja Cadastrada Com Sucesso!!!");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor, preencha todos os campos!");
            }
        }
    }
}
