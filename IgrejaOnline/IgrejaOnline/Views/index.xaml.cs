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
    /// Lógica interna para index.xaml
    /// </summary>
    public partial class index : Window
    {
        public index()
        {
            InitializeComponent();
        }
       
        public bool yesOrNot;
        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            {
                
                Controllers.User_Controller uc = new Controllers.User_Controller();

                Modelos.User QualUsu = uc.buscaFuncao(boxUsuario.Text);
                yesOrNot = uc.verificarLogin(boxUsuario.Text, BoxSenhaUsu.Password);
                

                if (yesOrNot == true)
                {
                    if (QualUsu.Funcao == "adm")
                    {
                        PaginaInicial pag1 = new PaginaInicial();
                        pag1.Show();
                        this.Close();
                    }
                    else
                    {
                        if(QualUsu.Funcao == "tesoureiro")
                        {
                            PaginaInicialTesoureiro pag2 = new PaginaInicialTesoureiro();
                            pag2.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            if(QualUsu.Funcao == "gestaoPessoas")
                            {
                                PaginaInicialGestorDePessoas pag3 = new PaginaInicialGestorDePessoas();
                                pag3.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                if(QualUsu.Funcao == "admEventos")
                                {
                                    PaginaInicialGestorEventos pag4 = new PaginaInicialGestorEventos();
                                    pag4.ShowDialog();
                                    this.Close();
                                }
                            }
                        }
                    }
                }
                }

            }
        }
    }

            








