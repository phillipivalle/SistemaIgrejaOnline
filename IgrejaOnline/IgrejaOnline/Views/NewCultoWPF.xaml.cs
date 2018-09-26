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
    /// Lógica interna para NewCultoWPF.xaml
    /// </summary>
    public partial class NewCultoWPF : Window
    {
        public NewCultoWPF()
        {
            InitializeComponent();
        }

        private void igrejaSelect_Loaded(object sender, RoutedEventArgs e)
        {
            Controllers.IgrejaController ic = new Controllers.IgrejaController();
            igrejaSelect.ItemsSource = ic.PesquisaNome();
            
        }

        

        private void pastorSelect_Loaded(object sender, RoutedEventArgs e)
        {
            Controllers.PastorController pc = new Controllers.PastorController();
            pastorSelect.ItemsSource = pc.PesquisaNome();
        }
      

        private void btnMarcarCulto_Click(object sender, RoutedEventArgs e)
        {


            Controllers.CultoController cc = new Controllers.CultoController();
            Controllers.PastorController pc = new Controllers.PastorController();
            Controllers.IgrejaController ic = new Controllers.IgrejaController();

            Modelos.Cultos inserindoCulto = new Modelos.Cultos();
            Modelos.Igrejas im = ic.pesquisaID(igrejaSelect.SelectedValue.ToString());
            Modelos.Pastores pm = pc.pesquisaID(pastorSelect.SelectedValue.ToString());

            inserindoCulto.PastoresId = pm.Id;
            inserindoCulto.Igrejas_ID = im.Id;

            inserindoCulto.Igrejas = im;
            inserindoCulto.Pastores = pm;
            
            inserindoCulto.DataCulto = Convert.ToDateTime(DataCultoBox.Text);
            inserindoCulto.HorarioCulto = boxHorario.Text;
            inserindoCulto.LocalCulto = im.NomeIgreja ;
            inserindoCulto.PastorCulto = pm.Nome;

            
            cc.inserirCulto(inserindoCulto);
            MessageBox.Show("Culto marcado com sucesso!!");
        }
    }
}
