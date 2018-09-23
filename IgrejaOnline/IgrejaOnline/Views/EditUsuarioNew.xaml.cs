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
    /// Lógica interna para EditUsuarioNew.xaml
    /// </summary>
    public partial class EditUsuarioNew : Window
    {
        
        public string funcao;
        public EditUsuarioNew()
        {
            InitializeComponent();
            //fazer view model, binding na tela
        }

        private void tesoureiro_Selected(object sender, RoutedEventArgs e)
        {
            funcao = "tesoureiro";
        }

        private void admEventos_Selected(object sender, RoutedEventArgs e)
        {
            funcao = "admEventos";
        }

        private void gestorPessoas_Selected(object sender, RoutedEventArgs e)
        {
            funcao = "gestaoPessoas";
        }

        private void adm_Selected(object sender, RoutedEventArgs e)
        {
            funcao = "adm";
        }

        private void btnCadastrarNewUsuario_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                Controllers.User_Controller uc = new Controllers.User_Controller();
                UsuariosCadastros att = new UsuariosCadastros();
                Modelos.User newUser = new Modelos.User();

                newUser.Id = Convert.ToInt16(BoxID.Text);
                newUser.Nome = BoxNameUser.Text;
                newUser.Login = BoxLoginUser.Text;
                newUser.Senha = boxSenhaUser.Password;
                newUser.Email = BoxEmail.Text;
                newUser.Funcao = funcao;
                uc.Editar(newUser.Id, newUser);
                MessageBox.Show("Editado com sucesso!!!");
                this.Close();
               
                att.GridListUser.ItemsSource = uc.ListarTodosUser();
                att.ShowDialog();
                   
            }
            catch (Exception)
            {
                MessageBox.Show("Preencha todos os campos");
            }



        }
    }
}
