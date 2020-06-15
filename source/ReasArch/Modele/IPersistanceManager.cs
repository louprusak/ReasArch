using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    public interface IPersistanceManager
    {
        /// <summary>
        /// Fonction sesant le chargement des fichier
        /// </summary>
        Monde ChargeDonnées();

        /// <summary>
        /// Fonction fesant la sauvegarde
        /// </summary>
        void SauvegardeDonnées(Monde LeMonde);
    }
}
