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
    /// Lógica interna para NovoUsuarioWPF.xaml
    /// </summary>
    public partial class NovoUsuarioWPF : Window
    {
        public NovoUsuarioWPF()
        {
            InitializeComponent();
        }
        private string funcao;
        private void btnCadastrarNewUsuario_Click(object sender, RoutedEventArgs e)
        {
            Modelos.User uCad = new Modelos.User();
            Controllers.User_Controller uc = new Controllers.User_Controller();  
            if(boxSenhaUser.Password.Equals(ConfirmSenha.Password))
            {
                uCad.Nome = BoxNameUser.Text;
                uCad.Login = BoxLoginUser.Text;
                uCad.Email = BoxEmail.Text;
                uCad.Funcao = funcao;
                uCad.Senha = boxSenhaUser.Password;
                uc.inserirUser(uCad);
            }
            else
            {
                MessageBox.Show("Senhas não iguais");
            }
        }

        private void adm_Selected(object sender, RoutedEventArgs e)
        {
            funcao = "adm";
        }

        private void tesoureiro_Selected(object sender, RoutedEventArgs e)
        {
            funcao = "tesoureiro";
        }

        private void gestorPessoas_Selected(object sender, RoutedEventArgs e)
        {
            funcao = "gestorPessoas";
        }

        private void admEventos_Selected(object sender, RoutedEventArgs e)
        {
            funcao = "admEventos";
        }
    }
}
