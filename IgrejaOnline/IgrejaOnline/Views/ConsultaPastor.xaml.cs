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
    /// Lógica interna para ConsultaPastor.xaml
    /// </summary>
    public partial class ConsultaPastor : Window
    {
        public ConsultaPastor()
        {
            InitializeComponent();
        }

        private void EditaPastor_Click(object sender, RoutedEventArgs e)
        {
            Modelos.Pastores pastorSelecionado = (Modelos.Pastores)GridListPastores.SelectedItem;
            PastorEdit newEdit = new PastorEdit();
            Controllers.PastorController pc = new Controllers.PastorController();

            newEdit.boxID.Text = pastorSelecionado.Id.ToString();
            newEdit.boxNome.Text = pastorSelecionado.Nome;
            newEdit.boxCpf.Text = pastorSelecionado.PastorCPF;
            newEdit.sexo = pastorSelecionado.PastorSexo;
            newEdit.DataNascimento.Text = pastorSelecionado.DataNascPastor.ToString();
            newEdit.boxEndPastor.Text = pastorSelecionado.EnderecoPastor;
            newEdit.boxNum.Text = pastorSelecionado.NumeroPastor.ToString();
            newEdit.boxCEP.Text = pastorSelecionado.CEPPastor;
            newEdit.BoxBairro.Text = pastorSelecionado.BairroPastor;
            newEdit.boxCidade.Text = pastorSelecionado.CidadePastor;
            newEdit.BoxUF.Text = pastorSelecionado.UFPastor;

            newEdit.ShowDialog();
            this.Close();
        }

        private void ExcluirPastor_Click(object sender, RoutedEventArgs e)
        {
            Modelos.Pastores pastorSelecionado = new Modelos.Pastores();
            Controllers.PastorController pc = new Controllers.PastorController();

            pc.Excluir(pastorSelecionado.Id);
            MessageBox.Show("Excluido com sucesso!");
            GridListPastores.ItemsSource = pc.ListarTodosPastores();
           

        }

        private void GridListPastores_Loaded(object sender, RoutedEventArgs e)
        {
            Controllers.PastorController pc = new Controllers.PastorController();
            GridListPastores.ItemsSource = pc.ListarTodosPastores();
        }
    }
}
