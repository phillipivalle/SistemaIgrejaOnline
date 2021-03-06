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
    /// Lógica interna para PaginaInicialGestorDePessoas.xaml
    /// </summary>
    public partial class PaginaInicialGestorDePessoas : Window
    {
        public PaginaInicialGestorDePessoas()
        {
            InitializeComponent();
        }

        private void btnNovoDizimista_Click(object sender, RoutedEventArgs e)
        {
            CadastroDizimista CadastrandoDizimistaGestor = new CadastroDizimista();
            CadastrandoDizimistaGestor.ShowDialog();
        }

        private void btnConsulta_Click(object sender, RoutedEventArgs e)
        {
            ConsultaDizimista ListandoDizimistaGestor = new ConsultaDizimista();
            ListandoDizimistaGestor.ShowDialog();
        }


        private void btnTotalDizimistas_Click(object sender, RoutedEventArgs e)
        {
            ConsultaDizimista GestorListaTotalDizimista = new ConsultaDizimista();
            GestorListaTotalDizimista.ShowDialog();
        }

        private void btnTotMulheres_Click(object sender, RoutedEventArgs e)
        {
            ListaMulheres GestorListaMulheres = new ListaMulheres();
            GestorListaMulheres.ShowDialog();
        }

        private void btnTotHomens_Click(object sender, RoutedEventArgs e)
        {
            ListaHomens GestorListaHomens = new ListaHomens();
            GestorListaHomens.ShowDialog();
        }

       

        private void btnNewPastor_Click(object sender, RoutedEventArgs e)
        {
            CadastroPastor GestorNewPastor = new CadastroPastor();
            GestorNewPastor.ShowDialog();
        }

        private void btnConsultarPastor_Click(object sender, RoutedEventArgs e)
        {
            ConsultaPastor GestorListaPastor = new ConsultaPastor();
            GestorListaPastor.ShowDialog();
        }
    }
}
