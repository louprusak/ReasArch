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
        public Batiment()
        {
            InitializeComponent();
        }

        public Batiment(System.Windows.Media.ImageSource image0, 
            System.Windows.Media.ImageSource image1,
            System.Windows.Media.ImageSource image2,
            System.Windows.Media.ImageSource image3,
            string nombat,
            string desbat)
        {
            InitializeComponent();
            IMG0 = image0;
            IMG1 = image1;
            IMG2 = image2;
            IMG3 = image3;
            Nom = nombat;
            Des = desbat;
        }

        public System.Windows.Media.ImageSource IMG0
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
        }
    }
}
