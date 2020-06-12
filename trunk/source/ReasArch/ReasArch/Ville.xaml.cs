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

        public Manager manager => (App.Current as App).LeManager;

        Modele.Ville ville;

        public Ville()
        {
            InitializeComponent();
        }

        public Ville(Modele.Ville ville)
        {
            InitializeComponent();
            this.ville = ville;
            Panorama.DataContext = ville;
            EnTeteVille.DataContext = ville;
            Afficheur_Batiments.DataContext = ville;
        }

        private void Ajouter_Batiment(object sender, RoutedEventArgs e)
        {
            Window modifierWindow = new AjouterBatiment();
            modifierWindow.ShowDialog();
        }

        private void Supprimer_Ville(object sender, RoutedEventArgs e)
        {
            MessageBoxResult res = MessageBox.Show("Voulez-vous vraiment supprimer cette ville ?", "Suppression de la ville", MessageBoxButton.OKCancel);
            if (res == MessageBoxResult.OK)
            {
                bool suppr = manager.SupprimerVille(ville);
                if(suppr == false)
                { MessageBox.Show("Erreur lors de la suppression de la ville...", "", MessageBoxButton.OK, MessageBoxImage.Error);}
            }
        }

        private void Modifier_Ville(object sender, RoutedEventArgs e)
        {
            Window modifierWindow = new ModifierVille();
            modifierWindow.ShowDialog();
        }

        private void BoutonListeBatiments_MouseUp(object sender, MouseButtonEventArgs e)
        {
            BoutonListeBatiments bouton = sender as BoutonListeBatiments;
            Modele.Batiment batiment = bouton.DataContext as Modele.Batiment;
            
            MainWindow main = Window.GetWindow(this) as MainWindow;
            main.fenetre.Content = new Batiment(batiment);
        }

        private void Afficheur_Batiments_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            manager.BatimentSelectionne = e.AddedItems[0] as Modele.Batiment;
        }

        private void Retour(object sender, RoutedEventArgs e)
        {
            MainWindow main = Window.GetWindow(this) as MainWindow;
            main.fenetre.Content = new Accueil();
        }
    }
}
