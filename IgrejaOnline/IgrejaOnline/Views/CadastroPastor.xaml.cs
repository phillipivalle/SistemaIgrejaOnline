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
    /// Lógica interna para CadastroPastor.xaml
    /// </summary>
    public partial class CadastroPastor : Window
    {
        private string opcaoSexual;

        public CadastroPastor()
        {
            InitializeComponent();
        }

        private void btnCadastrarNewPastor_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Controllers.PastorController pc = new Controllers.PastorController();
                Modelos.Pastores pastorCadastro = new Modelos.Pastores();

                string data = DataNascimento.Text;

                pastorCadastro.Nome = boxNome.Text;
                pastorCadastro.PastorCPF = boxCpf.Text;
                pastorCadastro.PastorSexo = opcaoSexual;
                pastorCadastro.DataNascPastor = Convert.ToDateTime(data);
                pastorCadastro.EnderecoPastor = boxEndPastor.Text;
                pastorCadastro.NumeroPastor = Convert.ToInt16(boxNum.Text);
                pastorCadastro.CEPPastor = boxCEP.Text;
                pastorCadastro.BairroPastor = BoxBairro.Text;
                pastorCadastro.CidadePastor = boxCidade.Text;
                pastorCadastro.UFPastor = BoxUF.Text;

                pc.inserirPastor(pastorCadastro);
                MessageBox.Show("Cadastrado com sucesso!!!");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor, preencha todos os campos");
            }
        }

            private void radioMasc_Checked(object sender, RoutedEventArgs e)
            {
                opcaoSexual = "M";
            }

            private void radioFem_Checked(object sender, RoutedEventArgs e)
            {
                opcaoSexual = "F";
            }
        }
    }


