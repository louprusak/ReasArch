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
    /// Logique d'interaction pour AjouterBatiment.xaml
    /// </summary>
    public partial class AjouterBatiment : Window
    {
        /// <summary>
        /// Lien vers le manager de l'application
        /// </summary>
        public Manager manager => (App.Current as App).LeManager;

        /// <summary>
        /// Batiment en cours de création dans la fenetre
        /// </summary>
        public Modele.Batiment LeBatiment { get; set; }

        /// <summary>
        /// Constructeur
        /// </summary>
        public AjouterBatiment()
        {
            InitializeComponent();
            var b = new Modele.Batiment("", manager.VilleSelectionnee.Pays, manager.VilleSelectionnee.Nom,"" , "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            LeBatiment = new Modele.Batiment(b.Nom, b.Pays, b.Ville, b.Quartier, b.Adresse, b.Architecte, b.Ingenieur, b.Style, b.Materiaux,
                b.Hauteur, b.Nbetages, b.Construction, b.Ouverture, b.Description, b.Imageprincipale, b.Imagearchitecte, b.Imageplan, b.Imageinterieur);
            DataContext = LeBatiment;
        }

        /// <summary>
        /// Ajoute le batiment crée après click sur bouton ajouter de la fenetre en appelant la méthode du manager et si erreur affiche une messagebox
        /// </summary>
        private void Ajouter_Batiment(object sender, RoutedEventArgs e)
        {
            bool res = manager.AjouterBatiment(LeBatiment);
            if (res == false) { MessageBox.Show("Erreur lors de l'ajout du batiment...", "", MessageBoxButton.OK, MessageBoxImage.Error); }
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
        /// Parcours, enregistrement et modification de l'image principale lors de l'appui sur le bouton parcourir
        /// </summary>
        private void ImagePrincipale_MouseUp(object sender, MouseButtonEventArgs e)
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
                File.Copy(dialog.FileName, System.IO.Path.Combine(StringToImageConverter.imagesPath,filename));
                LeBatiment.Imageprincipale = filename;
            }
            else MessageBox.Show("Image invalide !", "", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        /// <summary>
        /// Parcours, enregistrement et modification de l'image architecte lors de l'appui sur le bouton parcourir
        /// </summary>
        private void ImageArchitecte_MouseUp(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Images | *.png; *.jpg; *.gif";
            bool? retour = dialog.ShowDialog();
            if (retour == true) 
            {
                FileInfo fi = new FileInfo(dialog.FileName);
                string filename = fi.Name;
                int i = 0;
                while(File.Exists(System.IO.Path.Combine(StringToImageConverter.imagesPath, filename)))
                {
                    i++;
                    filename = $"{fi.Name.Remove(fi.Name.LastIndexOf('.'))}_{i}.{fi.Extension}";
                }
                File.Copy(dialog.FileName, System.IO.Path.Combine(StringToImageConverter.imagesPath, filename));
                LeBatiment.Imagearchitecte = filename;
            }
            else MessageBox.Show("Image invalide !", "", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        /// <summary>
        /// Parcours, enregistrement et modification de l'image plan lors de l'appui sur le bouton parcourir
        /// </summary>
        private void ImagePlan_MouseUp(object sender, MouseButtonEventArgs e)
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
                LeBatiment.Imageplan = filename;
            }
            else MessageBox.Show("Image invalide !", "", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        /// <summary>
        /// Parcours, enregistrement et modification de l'image interieur lors de l'appui sur le bouton parcourir
        /// </summary>
        private void ImageInterieur_MouseUp(object sender, MouseButtonEventArgs e)
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
                LeBatiment.Imageinterieur = filename;
            }
            else MessageBox.Show("Image invalide !", "", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
