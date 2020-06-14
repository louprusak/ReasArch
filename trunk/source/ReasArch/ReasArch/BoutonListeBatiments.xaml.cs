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
        public Modele.Batiment CeBatiment { get; set; }

        public BoutonListeBatiments()
        {
            InitializeComponent();
        }

        private void Modifier_Batiment(object sender, RoutedEventArgs e)
        {
            CeBatiment = DataContext as Modele.Batiment;
            Window modif = new ModifierBatiment(CeBatiment);
            modif.ShowDialog();
        }

        private void Supprimer_Batiment(object sender, RoutedEventArgs e)
        {
            CeBatiment = DataContext as Modele.Batiment;
            MessageBoxResult res = MessageBox.Show($"Voulez-vous vraiment supprimer le batiment :\n '{CeBatiment.Nom}' ?", "Suppression du batiment", MessageBoxButton.OKCancel);
            if (res == MessageBoxResult.OK)
            {
                bool suppr = manager.SupprimerBatiment(CeBatiment);
                if (suppr == false)
                { MessageBox.Show("Erreur lors de la suppression du batiment...", "", MessageBoxButton.OK, MessageBoxImage.Error); }
            }
        }
    }
}
