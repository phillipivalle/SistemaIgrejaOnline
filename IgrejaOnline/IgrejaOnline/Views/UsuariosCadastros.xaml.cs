using Modelos;
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
    /// Lógica interna para UsuariosCadastros.xaml
    /// </summary>
    public partial class UsuariosCadastros : Window
    {

        public UsuariosCadastros()
        {
            InitializeComponent();
        }

        private void ExcluirUser_Click(object sender, RoutedEventArgs e)
        {

            User usuarioSelecionado = (User)GridListUser.SelectedItem;

            Controllers.User_Controller uc = new Controllers.User_Controller();
            uc.Excluir(usuarioSelecionado);
            MessageBox.Show("Excluido com sucesso!");
            GridListUser.ItemsSource = uc.ListarTodosUser();



        }


        private void EditaUser_Click(object sender, RoutedEventArgs e)
        {

            User usuarioSelecionado = (User)GridListUser.SelectedItem;
            Controllers.User_Controller uc = new Controllers.User_Controller();
            EditUsuarioNew editNew = new EditUsuarioNew();

            editNew.BoxNameUser.Text = usuarioSelecionado.Nome;
            editNew.BoxID.Text = usuarioSelecionado.Id.ToString();
            editNew.boxSenhaUser.Password = usuarioSelecionado.Senha;
            editNew.BoxLoginUser.Text = usuarioSelecionado.Login;
            editNew.BoxEmail.Text = usuarioSelecionado.Email;
            editNew.funcao = usuarioSelecionado.Funcao;
            editNew.Show();
            this.Close();
            
        }

        private void GridListUser_Loaded(object sender, RoutedEventArgs e)
        {
            Controllers.User_Controller uc = new Controllers.User_Controller();
            GridListUser.ItemsSource = uc.ListarTodosUser();
        }
    }
}


    

