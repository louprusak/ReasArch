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
        /// <summary>
        /// Lien vers le manager de l'application
        /// </summary>
        public Manager manager => (App.Current as App).LeManager;

        /// <summary>
        /// Instance actuelle de Modele.Ville
        /// </summary>
        Modele.Ville ville;

        /// <summary>
        /// Constructeur
        /// </summary>
        public Ville()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructeur de la fenetre ville en fonction de l'instance de la ville passée en paramètre
        /// </summary>
        public Ville(Modele.Ville ville)
        {
            InitializeComponent();
            this.ville = ville;
            Panorama.DataContext = ville;
            EnTeteVille.DataContext = ville;
            Afficheur_Batiments.DataContext = ville;
        }

        /// <summary>
        /// Ouvre une fenetre d'ajout de batiment apres click sur le bouton 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ajouter_Batiment(object sender, RoutedEventArgs e)
        {
            Window modifierWindow = new AjouterBatiment();
            modifierWindow.ShowDialog();
        }

        /// <summary>
        /// Supprime la ville en appelant la méthode associée de manager
        /// </summary>
        private void Supprimer_Ville(object sender, RoutedEventArgs e)
        {
            MainWindow main = Window.GetWindow(this) as MainWindow;
            MessageBoxResult res = MessageBox.Show($"Voulez-vous vraiment supprimer la ville :\n '{ville.Nom}' ainsi que tous les batiments associés ?", "Suppression de la ville", MessageBoxButton.OKCancel);
            if (res == MessageBoxResult.OK)
            {
                bool suppr = manager.SupprimerVille(ville);
                if (suppr == false)
                { MessageBox.Show("Erreur lors de la suppression de la ville...", "", MessageBoxButton.OK, MessageBoxImage.Error); }
                else main.fenetre.Content = new Accueil();
            }
        }

        /// <summary>
        /// Ouvre une fenetre de modification de la ville actuelle
        /// </summary>
        private void Modifier_Ville(object sender, RoutedEventArgs e)
        {
            Window modifierWindow = new ModifierVille();
            modifierWindow.ShowDialog();
        }

        /// <summary>
        /// Ouvre la fenetre du batiment selectionné lors du click sur le bouton du batiment sur la page de la ville
        /// </summary>
        private void BoutonListeBatiments_MouseUp(object sender, MouseButtonEventArgs e)
        {
            BoutonListeBatiments bouton = sender as BoutonListeBatiments;
            Modele.Batiment batiment = bouton.DataContext as Modele.Batiment;
            
            MainWindow main = Window.GetWindow(this) as MainWindow;
            main.fenetre.Content = new Batiment(batiment);
        }

        /// <summary>
        /// Affiche la page d'accueil lors de l'appui sur le bouton retour de la page ville
        /// </summary>
        private void Retour(object sender, RoutedEventArgs e)
        {
            MainWindow main = Window.GetWindow(this) as MainWindow;
            main.fenetre.Content = new Accueil();
        }
    }
}
