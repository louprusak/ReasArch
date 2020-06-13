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
    /// Logique d'interaction pour AjouterBatiment.xaml
    /// </summary>
    public partial class AjouterBatiment : Window
    {
        public Manager manager => (App.Current as App).LeManager;
        public Modele.Batiment LeBatiment { get; set; }

        public AjouterBatiment()
        {
            InitializeComponent();
            var b = new Modele.Batiment("", manager.VilleSelectionnee.Pays, manager.VilleSelectionnee.Nom,"" , "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            LeBatiment = new Modele.Batiment(b.Nom, b.Pays, b.Ville, b.Quartier, b.Adresse, b.Architecte, b.Ingenieur, b.Style, b.Materiaux,
                b.Hauteur, b.NbEtages, b.Construction, b.Ouverture, b.Description, b.ImagePrincipale, b.ImageArchitecte, b.ImagePlan, b.ImageInterieur);
            DataContext = LeBatiment;
        }

        private void Ajouter_Batiment(object sender, RoutedEventArgs e)
        {
            bool res = manager.AjouterBatiment(LeBatiment);
            if (res == false) { MessageBox.Show("Erreur lors de l'ajout du batiment...", "", MessageBoxButton.OK, MessageBoxImage.Error); }
            Close();
        }

        private void Annuler(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
