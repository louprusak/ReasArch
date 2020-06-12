using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ReasArch
{
    /// <summary>
    /// Logique d'interaction pour AjouterBatiment.xaml
    /// </summary>
    public partial class AjouterBatiment : Window
    {
        public AjouterBatiment()
        {
            InitializeComponent();
        }

        private void Sauvegarder(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Annuler(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
