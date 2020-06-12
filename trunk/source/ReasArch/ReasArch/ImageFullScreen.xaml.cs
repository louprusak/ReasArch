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
using System.Windows.Shapes;

namespace ReasArch
{
    /// <summary>
    /// Logique d'interaction pour ImageFullScreen.xaml
    /// </summary>
    public partial class ImageFullScreen : Window
    {
        public Manager manager => (App.Current as App).LeManager;
        public string sourceimage { get; set; } = null;

        public ImageFullScreen()
        {
            InitializeComponent();
        }
        public ImageFullScreen(String source)
        {
            InitializeComponent();
            DataContext = this;
            sourceimage = source;
        }
    }
}
