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
    /// Logique d'interaction pour ModifierVille.xaml
    /// </summary>
    public partial class ModifierVille : Window
    {
        /// <summary>
        /// Lien vers le manager de l'application
        /// </summary>
        public Manager manager => (App.Current as App).LeManager;
        /// <summary>
        /// Référence de la ville avant modif
        /// </summary>
        public Modele.Ville OldVille { get; set; }
        /// <summary>
        /// Référence de la ville crée avec les modifs
        /// </summary>
        public Modele.Ville NewVille { get; set; }

        /// <summary>
        /// Constructeur
        /// </summary>
        public ModifierVille()
        {
            InitializeComponent();
            OldVille = manager.VilleSelectionnee;
            NewVille = new Modele.Ville(OldVille.Nom, OldVille.Pays, OldVille.Imagevignette, OldVille.Imagepanorama);
            DataContext = NewVille;
        }

        /// <summary>
        /// Sauvegarde de la ville modifiée : appel de la méthode de sauvegarde de manager et fermeture de la fenetre
        /// </summary>
        private void Sauvegarder(object sender, RoutedEventArgs e)
        {
            manager.ModifierVille(OldVille, NewVille);
            Close();
        }

        /// <summary>
        /// Ferme la fenetre si click sur la bouton annuler
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
                NewVille.Imagevignette = filename;
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
                NewVille.Imagepanorama = filename;
            }
            else MessageBox.Show("Image invalide !", "", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
