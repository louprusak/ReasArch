using Modele;
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
    /// Logique d'interaction pour ModifierVille.xaml
    /// </summary>
    public partial class ModifierVille : Window
    {
        public Manager manager => (App.Current as App).LeManager;

        public ModifierVille()
        {
            InitializeComponent();
            DataContext = manager.VilleSelectionnee;
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
