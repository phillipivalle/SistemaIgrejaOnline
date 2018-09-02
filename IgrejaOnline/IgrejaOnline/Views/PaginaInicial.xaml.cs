﻿using System;
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
    /// Lógica interna para PaginaInicial.xaml
    /// </summary>
    public partial class PaginaInicial : Window
    {
        public PaginaInicial()
        {
            InitializeComponent();
        }

        private void btnNovoDizimista_Click(object sender, RoutedEventArgs e)
        {
            CadastroDizimista cadastrarFiel = new CadastroDizimista();

            cadastrarFiel.ShowDialog();
        }
    }
}
