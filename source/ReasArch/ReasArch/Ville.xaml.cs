using Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ReasArch
{
    /// <summary>
    /// Logique d'interaction pour Ville.xaml
    /// </summary>
    public partial class Ville : UserControl
    {
       
        Modele.Ville ville = Stub.CreerVille();

        public Ville()
        {
            InitializeComponent();
            Panorama.DataContext = ville;
            EnTeteVille.DataContext = ville;
        }

        private void Ajouter_Batiment(object sender, RoutedEventArgs e)
        {
            Window modifierWindow = new AjoutModifBatiment();
            modifierWindow.ShowDialog();
        }

        
    }
}
