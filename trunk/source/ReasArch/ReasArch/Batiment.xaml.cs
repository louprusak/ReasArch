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
    /// Logique d'interaction pour Batiment.xaml
    /// </summary>
    public partial class Batiment : UserControl
    {
        /// <summary>
        /// Lien vers le manager de l'application
        /// </summary>
        public Manager manager => (App.Current as App).LeManager;
      
        /// <summary>
        /// Instance actuelle de Modele.batiment
        /// </summary>
        Modele.Batiment batiment;

        /// <summary>
        /// Constructeur
        /// </summary>
        public Batiment()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructeur de la page en fonction de l'instance actuelle de Modele.Batiment passée en paramètre
        /// </summary>
        public Batiment(Modele.Batiment batiment)
        {
            InitializeComponent();
            this.batiment = batiment;
            AfficheurBatiment.DataContext = batiment;
        }

        /// <summary>
        /// Affiche la fenetre de modification du batiment actuel après click sur le bouton modifier
        /// </summary>
        private void Modif(object sender, RoutedEventArgs e)
        {
            Window modif = new ModifierBatiment(batiment);
            modif.ShowDialog();
        }

        /// <summary>
        /// Retourne à la page de la ville actuelle
        /// </summary>
        private void Retour(object sender, RoutedEventArgs e)
        {
            MainWindow main = Window.GetWindow(this) as MainWindow;
            main.fenetre.Content = new Ville(manager.VilleSelectionnee);
        }

        /// <summary>
        /// Affiche en grand écran l'image principale après click sur celle-ci
        /// </summary>
        private void ImagePrincipale_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Window fullscreen = new ImageFullScreen(batiment.Imageprincipale);
            fullscreen.Show();
        }

        /// <summary>
        /// Affiche en grand écran l'image architecte après click sur celle-ci
        /// </summary>
        private void ImageArchitecte_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Window fullscreen = new ImageFullScreen(batiment.Imagearchitecte);
            fullscreen.Show();
        }

        /// <summary>
        /// Affiche en grand écran l'image plan après click sur celle-ci
        /// </summary>
        private void ImagePlan_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Window fullscreen = new ImageFullScreen(batiment.Imageplan);
            fullscreen.Show();
        }

        /// <summary>
        /// Affiche en grand écran l'image interieur après click sur celle-ci
        /// </summary>
        private void ImageInterieur_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Window fullscreen = new ImageFullScreen(batiment.Imageinterieur);
            fullscreen.Show();
        }
    }
}
