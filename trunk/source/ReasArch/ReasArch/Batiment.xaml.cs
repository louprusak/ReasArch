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
        public Manager manager => (App.Current as App).LeManager;
        Modele.Batiment batiment;

        public Batiment()
        {
            InitializeComponent();
        }

        public Batiment(Modele.Batiment batiment)
        {
            InitializeComponent();
            this.batiment = batiment;
            AfficheurBatiment.DataContext = batiment;
        }

        private void Modif(object sender, RoutedEventArgs e)
        {
            Window modif = new ModifierBatiment(batiment);
            modif.ShowDialog();
        }

        private void Retour(object sender, RoutedEventArgs e)
        {
            MainWindow main = Window.GetWindow(this) as MainWindow;
            main.fenetre.Content = new Ville(manager.VilleSelectionnee);
        }

        private void ImagePrincipale_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Window fullscreen = new ImageFullScreen(batiment.Imageprincipale);
            fullscreen.Show();
        }

        private void ImageArchitecte_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Window fullscreen = new ImageFullScreen(batiment.Imagearchitecte);
            fullscreen.Show();
        }

        private void ImagePlan_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Window fullscreen = new ImageFullScreen(batiment.Imageplan);
            fullscreen.Show();
        }

        private void ImageInterieur_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Window fullscreen = new ImageFullScreen(batiment.Imageinterieur);
            fullscreen.Show();
        }
    }
}
