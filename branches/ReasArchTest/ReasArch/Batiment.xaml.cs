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

        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            System.Windows.Media.ImageSource source = sender as ImageSource;
            MainWindow main = Window.GetWindow(this) as MainWindow;
            main.fenetre = new PleinEcran(source);
        }



        /*public System.Windows.Media.ImageSource IMG0
        {
            set
            {
                IMGBatPrincipale.Source = value;
            }
        }
        public System.Windows.Media.ImageSource IMG1
        {
            set
            {
                IMGBat1.Source = value;
            }
        }
        public System.Windows.Media.ImageSource IMG2
        {
            set
            {
                IMGBat2.Source = value;
            }
        }
        public System.Windows.Media.ImageSource IMG3
        {
            set
            {
                IMGBat3.Source = value;
            }
        }
        public string Nom
        {
            set
            {
                TBNomBat.Text = value;
            }
        }
        public string Des
        {
            set
            {
                TBDesBat.Text = value;
            }
        }*/
    }
}
