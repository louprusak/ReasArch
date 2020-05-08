using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    public class Batiment
    {
        /// <summary>
        /// Nom du batiment
        /// </summary>
        public string Nom { get; private set; }

        /// <summary>
        /// Ville dans laquelle se trouve le batiment
        /// </summary>
        public string Ville { get; private set; }

        /// <summary>
        /// Nom de l'architecte du batiment
        /// </summary>
        public string Architecte { get; private set; }

        /// <summary>
        /// Description autre du batiment
        /// </summary>
        public string Description { get; private set; }

        public Batiment (string nom, string architecte, string description)
        {
            Nom = nom;
            Architecte = architecte;
            Description = description;
        }

        public Batiment (string nom, string ville, string architecte, string description)
            : this(nom, architecte, description)
        {
            Ville = ville;
        }
    }
}
