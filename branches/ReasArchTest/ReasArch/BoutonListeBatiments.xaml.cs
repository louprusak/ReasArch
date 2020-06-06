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
    /// Logique d'interaction pour BoutonListeBatiments.xaml
    /// </summary>
    public partial class BoutonListeBatiments : UserControl
    {
        public Manager manager => (App.Current as App).LeManager;

        public BoutonListeBatiments()
        {
            InitializeComponent();
        }

        public System.Windows.Media.ImageSource Source
        {
            set
            {
                Image.Source = value;
            }
        }

        public string NomBat
        {
            set
            {
                Titre.Text = value;
            }
        }

        private void Modifier_Batiment(object sender, RoutedEventArgs e)
        {
            Window modif = new AjoutModifBatiment();
            modif.ShowDialog();
        }

        private void Supprimer_Batiment(object sender, RoutedEventArgs e)
        {
            MessageBoxResult res = MessageBox.Show("Voulez-vous vraiment supprimer ce bâtiment ?", "Suppression du bâtiment", MessageBoxButton.OKCancel);
        }
    }
}
