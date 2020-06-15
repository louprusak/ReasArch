using Microsoft.Win32;
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
    /// Logique d'interaction pour TextBlock_Bouton.xaml
    /// </summary>
    public partial class TextBlock_Bouton : UserControl
    {
        /// <summary>
        /// Lien vers le manager de l'application
        /// </summary>
        public Manager manager => (App.Current as App).LeManager;

        /// <summary>
        /// Constructeur
        /// </summary>
        public TextBlock_Bouton()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Texte du bouton
        /// </summary>
        public string Texte
        {
            set
            {
                MonTextBlock.Text = value;
            }
        }

        /// <summary>
        /// Ouvre une fenetre de choix d'image dans les fichiers
        /// </summary>
        private void Choisir_Image(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Images | *.png; *.jpg; *.gif";
            dialog.ShowDialog();
        }
    }
}
