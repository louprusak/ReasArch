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
    /// Logique d'interaction pour BoutonListeVilles.xaml
    /// </summary>
    public partial class BoutonListeVilles : UserControl
    {

        public Manager manager => (App.Current as App).LeManager;

        public BoutonListeVilles()
        {
            InitializeComponent();
        }
    }
}
