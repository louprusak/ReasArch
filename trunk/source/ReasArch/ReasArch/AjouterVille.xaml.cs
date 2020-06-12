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
    /// Logique d'interaction pour AjouterVille.xaml
    /// </summary>
    public partial class AjouterVille : Window
    {
        public Manager manager => (App.Current as App).LeManager;

        public Modele.Ville LaVille { get; set; }

        public AjouterVille()
        {
            InitializeComponent();
            var v = new Modele.Ville("//unknown//", "", "");
            LaVille = new Modele.Ville(v.Nom, v.ImageVignette, v.ImagePanorama);
            DataContext = LaVille;
        }

        private void Ajouter_Ville(object sender, RoutedEventArgs e)
        {
            /*if(manager.monde.GetVille(LaVille.Nom) != null)
            {
                MessageBox.Show("Une ville avec ce nom est déjà présente dans l'application !", "", MessageBoxButton.OK, MessageBoxImage.Error);
            }*/
            bool res = manager.AjouterVille(LaVille);
            if(res == false) { MessageBox.Show("Erreur lors de l'ajout de la ville...", "", MessageBoxButton.OK, MessageBoxImage.Error); }
            Close();
        }
    }
}
