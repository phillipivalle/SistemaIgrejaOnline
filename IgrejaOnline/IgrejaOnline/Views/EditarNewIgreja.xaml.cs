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
    /// Lógica interna para EditarNewIgreja.xaml
    /// </summary>
    public partial class EditarNewIgreja : Window
    {
        public EditarNewIgreja()
        {
            InitializeComponent();
        }

        private void btnEditarIgreja_Click(object sender, RoutedEventArgs e)
        {
            ConsultaIgreja att = new ConsultaIgreja();
            Controllers.IgrejaController ic = new Controllers.IgrejaController();
            Modelos.Igrejas iInserir = new Modelos.Igrejas();
            iInserir.Id = Convert.ToInt16(boxID.Text);
            iInserir.NomeIgreja = boxNomeIgreja.Text;
            iInserir.EnderecoIgreja = boxEnd.Text;
            iInserir.NumeroIgreja = Convert.ToInt16(boxNumIgreja.Text);
            iInserir.BairroIgreja = boxBairroIgreja.Text;
            iInserir.UFIgreja = boxUFIgreja.Text;
            iInserir.CNPJIgreja = boxCNPJ.Text;
            iInserir.SiteIgreja = BoxSiteIgreja.Text;

            ic.Editar(iInserir.Id, iInserir);
            this.Close();
            att.GridListIgrejas.SelectedItem = ic.ListarTodasIgrejas();
            att.ShowDialog();

        }
    }
}
