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
        public Manager manager => (App.Current as App).LeManager;


        public MainWindow()
        {
            InitializeComponent();
            AfficheurVilles.DataContext = manager;
        }

        private void Ajout_Ville(object sender, RoutedEventArgs e)
        {
            Window nouvelle_ville = new AjouterVille();
            nouvelle_ville.ShowDialog();
        }

        private void BoutonListeVilles_MouseUp(object sender, MouseButtonEventArgs e)
        {
            BoutonListeVilles bouton = sender as BoutonListeVilles;
            Modele.Ville ville = bouton.DataContext as Modele.Ville;
            fenetre.Content = new Ville(ville);
        }

        private void AfficheurVilles_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            manager.VilleSelectionnee = e.AddedItems[0] as Modele.Ville;
        }
    }
}
