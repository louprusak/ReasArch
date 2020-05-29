﻿using Data;
using Modele;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ReasArch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Manager manager = Stub.CreerManager();

        public MainWindow()
        {
            InitializeComponent();
            AfficheurVilles.DataContext = manager;
            
        }

        private void Nouveau_Batiment(object sender, RoutedEventArgs e)
        {
            fenetre.Content = new Batiment();
        }

        private void Nouvelle_Ville(object sender, RoutedEventArgs e)
        {
            fenetre.Content = new Ville();
        }

        private void Ajout_Modif_Batiment(object sender, RoutedEventArgs e)
        {
            fenetre.Content = new BatimentUtils();
        }

        private void Ajout_Modif_Ville(object sender, RoutedEventArgs e)
        {
            fenetre.Content = new VilleUtils();
        }
    }
}
