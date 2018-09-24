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
    /// Lógica interna para PastorEdit.xaml
    /// </summary>
    public partial class PastorEdit : Window
    {
        public PastorEdit()
        {
            InitializeComponent();
        }
        public string sexo;
        private void btnEditarPastor_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void radioMasc_Checked(object sender, RoutedEventArgs e)
        {
            sexo = "M";
        }

        private void radioFem_Checked(object sender, RoutedEventArgs e)
        {
            sexo = "F";
        }

        private void btnEditarPastor_Click_1(object sender, RoutedEventArgs e)
        {
            Modelos.Pastores pEditar = new Modelos.Pastores();
            Controllers.PastorController pc = new Controllers.PastorController();
            ConsultaPastor att = new ConsultaPastor();

            pEditar.Id = Convert.ToInt16(boxID.Text);
            pEditar.Nome = boxNome.Text;
            pEditar.PastorCPF = boxCpf.Text;
            pEditar.PastorSexo = sexo;
            pEditar.DataNascPastor = Convert.ToDateTime(DataNascimento.Text);
            pEditar.EnderecoPastor = boxEndPastor.Text;
            pEditar.NumeroPastor = Convert.ToInt16(boxNum.Text);
            pEditar.CEPPastor = boxCEP.Text;
            pEditar.BairroPastor = BoxBairro.Text;
            pEditar.CidadePastor = boxCidade.Text;
            pEditar.UFPastor = BoxUF.Text;

            pc.Editar(pEditar.Id, pEditar);
            MessageBox.Show("Editado com sucesso!");
            this.Close();
            att.GridListPastores.SelectedItem = pc.ListarTodosPastores();
            att.ShowDialog();


        }
    }
}
