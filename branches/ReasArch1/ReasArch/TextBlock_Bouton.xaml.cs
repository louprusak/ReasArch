using Microsoft.Win32;
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
        public TextBlock_Bouton()
        {
            InitializeComponent();
        }

        public string Texte
        {
            set
            {
                MonTextBlock.Text = value;
            }
        }

        private void Choisir_Image(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Images | *.png; *.jpg; *.gif";
            dialog.ShowDialog();
        }
    }
}
