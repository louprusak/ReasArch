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
    /// Logique d'interaction pour Accueil.xaml
    /// </summary>
    public partial class Accueil : UserControl
    {
        /// <summary>
        /// Lien vers le manager de l'application
        /// </summary>
        public Manager manager => (App.Current as App).LeManager;

        /// <summary>
        /// Constructeur
        /// </summary>
        public Accueil()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Affiche la page d'ajout de ville après click sur le bouton ajouterville de l'accueil
        /// </summary>
        private void Ajout_Ville(object sender, RoutedEventArgs e)
        {
            Window nouvelle_ville = new AjouterVille();
            nouvelle_ville.ShowDialog();
        }


        /// <summary>
        /// Fait la sauvegarde des changements et affiche un message
        /// </summary>
        private void Sauvegarde(object sender, RoutedEventArgs e)
        {
            manager.SauvegardeDonnées();
            MessageBox.Show("Sauvegarde réussie", "Sauvegarde",
                    MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
