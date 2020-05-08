using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    class Manager
    {
        public List<Ville> Listevilles { get; private set; }

        public Manager()
        {
            List<Ville> liste = new List<Ville>();
            Listevilles = liste;
        }

        public bool AjouterVille (string nom)
        {
            Ville ville = new Ville(nom);
            Listevilles.Add(ville);
            return true;
        }

        public bool SupprimerVille (string nom)
        {
            return true;
        }

        public bool ModifierVille (string nom)
        {
            return true;
        }

        public bool AjouterBatiment(string nomville, string nombat, string architecte, string descriptionbat)
        {
            ///recherche de la ville avec le nom dans la liste
            ///appel de la fonction ajouter batiment depuis l'élément de la liste ville
            return true;
        }

        public bool SupprimerBatiment (string nomville, string nombat)
        {
            return true;
        }

        public bool ModifierBatiment( string nomville, string nombat)
        {
            return true;
        }
    }
}
