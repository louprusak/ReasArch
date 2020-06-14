using Microsoft.Win32;
using Modele;
using ReasArch.converters;
using System;
using System.Collections.Generic;
using System.IO;
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
            var v = new Modele.Ville("//unknown//", "//unknown//", "", "");
            LaVille = new Modele.Ville(v.Nom, v.Pays, v.Imagevignette, v.Imagepanorama);
            DataContext = LaVille;
        }

        private void Ajouter_Ville(object sender, RoutedEventArgs e)
        {
            bool res = manager.AjouterVille(LaVille);
            if(res == false) { MessageBox.Show("Erreur lors de l'ajout de la ville...", "", MessageBoxButton.OK, MessageBoxImage.Error); }
            Close();
        }

        private void Annuler(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ImageVignette_MouseUp(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Images | *.png; *.jpg; *.gif";
            bool? retour = dialog.ShowDialog();
            if (retour == true)
            {
                FileInfo fi = new FileInfo(dialog.FileName);
                string filename = fi.Name;
                File.Copy(dialog.FileName, System.IO.Path.Combine(StringToImageConverter.imagesPath, filename));
                LaVille.Imagevignette = filename;
            }
            else MessageBox.Show("Image invalide !", "", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void ImagePanorama_MouseUp(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Images | *.png; *.jpg; *.gif";
            bool? retour = dialog.ShowDialog();
            if (retour == true)
            {
                FileInfo fi = new FileInfo(dialog.FileName);
                string filename = fi.Name;
                File.Copy(dialog.FileName, System.IO.Path.Combine(StringToImageConverter.imagesPath, filename));
                LaVille.Imagepanorama = filename;
            }
            else MessageBox.Show("Image invalide !", "", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        
    }
}
