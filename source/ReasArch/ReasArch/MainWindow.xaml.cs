using Data;
using Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Lien vers le manager de l'application
        /// </summary>
        public Manager manager => (App.Current as App).LeManager;

        /// <summary>
        /// Constructeur
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            AfficheurVilles.DataContext = manager;
        }

        /// <summary>
        /// Affichage de la fenetre d'ajout d'une ville suite au click sur le bouton ajouter ville
        /// </summary>
        private void Ajout_Ville(object sender, RoutedEventArgs e)
        {
            Window nouvelle_ville = new AjouterVille();
            nouvelle_ville.ShowDialog();
        }


        private void Sauvegarde(object sender, RoutedEventArgs e)
        {
            manager.SauvegardeDonnées();
            MessageBox.Show("Sauvegarde réussie", "Sauvegarde",
                    MessageBoxButton.OK, MessageBoxImage.Information);
        }


        /// <summary>
        /// Affichage de la page de la ville lors de la selection d'une ville dans la listebox
        /// </summary>
        private void BoutonListeVilles_MouseUp(object sender, MouseButtonEventArgs e)
        {
            BoutonListeVilles bouton = sender as BoutonListeVilles;
            Modele.Ville ville = bouton.DataContext as Modele.Ville;
            fenetre.Content = new Ville(ville);
        }
    }
}
