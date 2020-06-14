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
    /// Logique d'interaction pour ModifierBatiment.xaml
    /// </summary>
    public partial class ModifierBatiment : Window
    {
        public Manager manager => (App.Current as App).LeManager;
        public Modele.Batiment OldBatiment { get; set; }
        public Modele.Batiment NewBatiment { get; set; }

        public ModifierBatiment()
        {
            InitializeComponent();
        }

        public ModifierBatiment(Modele.Batiment batiment)
        {
            InitializeComponent();
            OldBatiment = batiment;
            var b = batiment;
            NewBatiment = new Modele.Batiment(b.Nom, b.Pays, b.Ville, b.Quartier, b.Adresse, b.Architecte, b.Ingenieur, b.Style, b.Materiaux, b.Hauteur, 
                b.Nbetages, b.Construction, b.Ouverture, b.Description, b.Imageprincipale, b.Imagearchitecte, b.Imageplan, b.Imageinterieur);
            DataContext = NewBatiment;
        }

        private void Sauvegarder(object sender, RoutedEventArgs e)
        {
            manager.ModifierBatiment(OldBatiment, NewBatiment);
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
                int i = 0;
                while (File.Exists(System.IO.Path.Combine(StringToImageConverter.imagesPath, filename)))
                {
                    i++;
                    filename = $"{fi.Name.Remove(fi.Name.LastIndexOf('.'))}_{i}.{fi.Extension}";
                }
                File.Copy(dialog.FileName, System.IO.Path.Combine(StringToImageConverter.imagesPath, filename));
                NewBatiment.Imageprincipale = filename;
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
                int i = 0;
                while (File.Exists(System.IO.Path.Combine(StringToImageConverter.imagesPath, filename)))
                {
                    i++;
                    filename = $"{fi.Name.Remove(fi.Name.LastIndexOf('.'))}_{i}.{fi.Extension}";
                }
                File.Copy(dialog.FileName, System.IO.Path.Combine(StringToImageConverter.imagesPath, filename));
                NewBatiment.Imagearchitecte = filename;
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
                int i = 0;
                while (File.Exists(System.IO.Path.Combine(StringToImageConverter.imagesPath, filename)))
                {
                    i++;
                    filename = $"{fi.Name.Remove(fi.Name.LastIndexOf('.'))}_{i}.{fi.Extension}";
                }
                File.Copy(dialog.FileName, System.IO.Path.Combine(StringToImageConverter.imagesPath, filename));
                NewBatiment.Imageplan = filename;
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
                int i = 0;
                while (File.Exists(System.IO.Path.Combine(StringToImageConverter.imagesPath, filename)))
                {
                    i++;
                    filename = $"{fi.Name.Remove(fi.Name.LastIndexOf('.'))}_{i}.{fi.Extension}";
                }
                File.Copy(dialog.FileName, System.IO.Path.Combine(StringToImageConverter.imagesPath, filename));
                NewBatiment.Imageinterieur = filename;
            }
            else MessageBox.Show("Image invalide !", "", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
