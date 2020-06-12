﻿using System;
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
    /// Logique d'interaction pour ModifierBatiment.xaml
    /// </summary>
    public partial class ModifierBatiment : Window
    {
        public ModifierBatiment()
        {
            InitializeComponent();
        }

        public ModifierBatiment(Modele.Batiment batiment)
        {
            InitializeComponent();
            DataContext = batiment;
        }
    }
}