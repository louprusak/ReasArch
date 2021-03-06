using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Data;
using Modele;

namespace ReasArch
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public Manager LeManager { get; set; } = new Manager(new DataContractPersistance.DataContractPers());

        /// <summary>
        /// Charge les données dans le ficier XML
        /// </summary>
        public App()
        {
            LeManager.ChargeDonnées();
        }
    }
}
