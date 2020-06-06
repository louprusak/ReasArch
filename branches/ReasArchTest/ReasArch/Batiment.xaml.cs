using Data;
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
    /// Logique d'interaction pour Batiment.xaml
    /// </summary>
    public partial class Batiment : UserControl
    {
        public Manager manager => (App.Current as App).LeManager;

        public Batiment()
        {
            InitializeComponent();
        }

        private void Modif(object sender, RoutedEventArgs e)
        {
            Window modif = new AjoutModifBatiment();
            modif.ShowDialog();
        }



        /*public System.Windows.Media.ImageSource IMG0
        {
            set
            {
                IMGBatPrincipale.Source = value;
            }
        }
        public System.Windows.Media.ImageSource IMG1
        {
            set
            {
                IMGBat1.Source = value;
            }
        }
        public System.Windows.Media.ImageSource IMG2
        {
            set
            {
                IMGBat2.Source = value;
            }
        }
        public System.Windows.Media.ImageSource IMG3
        {
            set
            {
                IMGBat3.Source = value;
            }
        }
        public string Nom
        {
            set
            {
                TBNomBat.Text = value;
            }
        }
        public string Des
        {
            set
            {
                TBDesBat.Text = value;
            }
        }*/
    }
}
