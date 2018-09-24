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
    /// Lógica interna para ConsultaDizimista.xaml
    /// </summary>
    public partial class ConsultaDizimista : Window
    {
        public ConsultaDizimista()
        {
            InitializeComponent();

            Controllers.DizimistaController dc = new Controllers.DizimistaController();
            List<Modelos.Dizimistas> listaDizimista = new List<Modelos.Dizimistas>();

            listaDizimista = dc.ListarTodosDizimistas();
        }

        private void GridListDizimista_Loaded(object sender, RoutedEventArgs e)
        {
            Controllers.DizimistaController dc = new Controllers.DizimistaController();
            GridListDizimista.ItemsSource = dc.ListarTodosDizimistas();
        }

        private void EditaDizimista_Click(object sender, RoutedEventArgs e)
        {
            Modelos.Dizimistas DizimistaSelecionado = (Modelos.Dizimistas)GridListDizimista.SelectedItem;
            Controllers.DizimistaController dc = new Controllers.DizimistaController();
            EditarDizimista newEdit = new EditarDizimista();
            newEdit.boxID.Text = DizimistaSelecionado.Id.ToString();
            newEdit.boxNome.Text = DizimistaSelecionado.Nome;
            newEdit.boxCpf.Text = DizimistaSelecionado.CPF;
            newEdit.sexo = DizimistaSelecionado.Sexo;
            newEdit.BoxDataNascimento.Text = DizimistaSelecionado.DataNasci.ToString();
            newEdit.boxEnd.Text = DizimistaSelecionado.Endereco;
            newEdit.boxNum.Text = DizimistaSelecionado.Numero.ToString();
            newEdit.boxBairro.Text = DizimistaSelecionado.Bairro;
            newEdit.boxCEP.Text = DizimistaSelecionado.CEP;
            newEdit.boxCidade.Text = DizimistaSelecionado.Cidade;
            newEdit.boxUF.Text = DizimistaSelecionado.UF;
            newEdit.boxNumCartao.Text = DizimistaSelecionado.NCartao;
            newEdit.boxValidade.Text = DizimistaSelecionado.Validade.ToString();
            newEdit.boxSeguranca.Text = DizimistaSelecionado.CodSeguranca;
            newEdit.boxSalario.Text = DizimistaSelecionado.Salario.ToString();
            newEdit.boxNomeCard.Text = DizimistaSelecionado.NomeImpresso;
            newEdit.bandeira = DizimistaSelecionado.Bandeira;
            this.Close();
            newEdit.ShowDialog();





        }

        private void ExcluirDizimista_Click(object sender, RoutedEventArgs e)
        {
            Modelos.Dizimistas DizimistaSelecionado = (Modelos.Dizimistas)GridListDizimista.SelectedItem;
            Controllers.DizimistaController dc = new Controllers.DizimistaController();
            dc.Excluir(DizimistaSelecionado.Id);
            MessageBox.Show("Excluido com sucesso");
            GridListDizimista.ItemsSource = dc.ListarTodosDizimistas();

        }
    }
}
