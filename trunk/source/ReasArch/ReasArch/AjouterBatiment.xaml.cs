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
        public Manager manager => (App.Current as App).LeManager;
        public Modele.Batiment LeBatiment { get; set; }

        public AjouterBatiment()
        {
            InitializeComponent();
            var b = new Modele.Batiment("", manager.VilleSelectionnee.PAYS, manager.VilleSelectionnee.NOM,"" , "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            LeBatiment = new Modele.Batiment(b.NOM, b.PAYS, b.VILLE, b.QUARTIER, b.ADRESSE, b.ARCHITECTE, b.INGENIEUR, b.STYLE, b.MATERIAUX,
                b.HAUTEUR, b.NBETAGES, b.CONSTRUCTION, b.OUVERTURE, b.DESCRIPTION, b.IMAGEPRINCIPALE, b.IMAGEARCHITECTE, b.IMAGEPLAN, b.IMAGEINTERIEUR);
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

        private void ImagePrincipale_MouseUp(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Images | *.png; *.jpg; *.gif";
            bool? retour = dialog.ShowDialog();
            if (retour == true) 
            {
                FileInfo fi = new FileInfo(dialog.FileName);
                string filename = fi.Name;
                File.Copy(dialog.FileName, System.IO.Path.Combine(StringToImageConverter.imagesPath,filename));
                LeBatiment.IMAGEPRINCIPALE = filename;
            }
            else MessageBox.Show("Image invalide !", "", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void ImageArchitecte_MouseUp(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Images | *.png; *.jpg; *.gif";
            bool? retour = dialog.ShowDialog();
            if (retour == true) 
            {
                FileInfo fi = new FileInfo(dialog.FileName);
                string filename = fi.Name;
                File.Copy(dialog.FileName, System.IO.Path.Combine(StringToImageConverter.imagesPath, filename));
                LeBatiment.IMAGEARCHITECTE = filename;
            }
            else MessageBox.Show("Image invalide !", "", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void ImagePlan_MouseUp(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Images | *.png; *.jpg; *.gif";
            bool? retour = dialog.ShowDialog();
            if (retour == true)
            {
                FileInfo fi = new FileInfo(dialog.FileName);
                string filename = fi.Name;
                File.Copy(dialog.FileName, System.IO.Path.Combine(StringToImageConverter.imagesPath, filename));
                LeBatiment.IMAGEPLAN = filename;
            }
            else MessageBox.Show("Image invalide !", "", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void ImageInterieur_MouseUp(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Images | *.png; *.jpg; *.gif";
            bool? retour = dialog.ShowDialog();
            if (retour == true)
            {
                FileInfo fi = new FileInfo(dialog.FileName);
                string filename = fi.Name;
                File.Copy(dialog.FileName, System.IO.Path.Combine(StringToImageConverter.imagesPath, filename));
                LeBatiment.IMAGEINTERIEUR = filename;
            }
            else MessageBox.Show("Image invalide !", "", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
