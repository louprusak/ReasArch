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
        /// <summary>
        /// Lien vers le manager de l'application
        /// </summary>
        public Manager manager => (App.Current as App).LeManager;

        /// <summary>
        /// Ville en cours de création dans la fenetre
        /// </summary>
        public Modele.Ville LaVille { get; set; }

        /// <summary>
        /// Constructeur
        /// </summary>
        public AjouterVille()
        {
            InitializeComponent();
            var v = new Modele.Ville("", "", "", "");
            LaVille = new Modele.Ville(v.Nom, v.Pays, v.Imagevignette, v.Imagepanorama);
            DataContext = LaVille;
        }

        /// <summary>
        /// Ajout de la ville crée lors de l'appui sur le bouton sauvegarder avec appel de la méthode dédiée de manager et si erreur affiche une message box
        /// </summary>
        private void Ajouter_Ville(object sender, RoutedEventArgs e)
        {
            bool res = manager.AjouterVille(LaVille);
            if(res == false) { MessageBox.Show("Erreur lors de l'ajout de la ville...", "", MessageBoxButton.OK, MessageBoxImage.Error); }
            Close();
        }

        /// <summary>
        /// Ferme la fenetre d'ajout si click sur le bouton annuler de celle-ci
        /// </summary>
        private void Annuler(object sender, RoutedEventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Parcours, enregistrement et modification de l'image vignette lors de l'appui sur le bouton parcourir
        /// </summary>
        private void ImageVignette_MouseUp(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Images | *.png; *.jpg; *.gif";
            bool? retour = dialog.ShowDialog();
            if (retour == true)
            {
                FileInfo fi = new FileInfo(dialog.FileName);
                string filename = fi.Name;
                int i = 0;
                while (File.Exists(System.IO.Path.Combine(StringToImageConverter.imagesPath, filename)))
                {
                    i++;
                    filename = $"{fi.Name.Remove(fi.Name.LastIndexOf('.'))}_{i}.{fi.Extension}";
                }
                File.Copy(dialog.FileName, System.IO.Path.Combine(StringToImageConverter.imagesPath, filename));
                LaVille.Imagevignette = filename;
            }
            else MessageBox.Show("Image invalide !", "", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        /// <summary>
        /// Parcours, enregistrement et modification de l'image panorama lors de l'appui sur le bouton parcourir
        /// </summary>
        private void ImagePanorama_MouseUp(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Images | *.png; *.jpg; *.gif";
            bool? retour = dialog.ShowDialog();
            if (retour == true)
            {
                FileInfo fi = new FileInfo(dialog.FileName);
                string filename = fi.Name;
                int i = 0;
                while (File.Exists(System.IO.Path.Combine(StringToImageConverter.imagesPath, filename)))
                {
                    i++;
                    filename = $"{fi.Name.Remove(fi.Name.LastIndexOf('.'))}_{i}.{fi.Extension}";
                }
                File.Copy(dialog.FileName, System.IO.Path.Combine(StringToImageConverter.imagesPath, filename));
                LaVille.Imagepanorama = filename;
            }
            else MessageBox.Show("Image invalide !", "", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        
    }
}
