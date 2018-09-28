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
            //Modelos.Igrejas im = ic.pesquisaID(igrejaSelect.SelectedValue.ToString());
            //Modelos.Pastores pm = pc.pesquisaID(pastorSelect.SelectedValue.ToString());

            
            
           inserindoCulto.Igrejas = ic.pesquisaID(igrejaSelect.SelectedValue.ToString()); 
           inserindoCulto.Pastores = pc.pesquisaID(pastorSelect.SelectedValue.ToString());

            inserindoCulto.Igrejas_ID = inserindoCulto.Igrejas.Id;
            inserindoCulto.LocalCulto = inserindoCulto.Igrejas.NomeIgreja;

            inserindoCulto.PastoresId = inserindoCulto.Pastores.Id;
            inserindoCulto.PastorCulto = inserindoCulto.Pastores.Nome;

            inserindoCulto.DataCulto = Convert.ToDateTime(DataCultoBox.Text);
            inserindoCulto.HorarioCulto = boxHorario.Text;



            
            cc.inserirCulto(inserindoCulto);
            MessageBox.Show("Culto marcado com sucesso!!");
        }
    }
}
