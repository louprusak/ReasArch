using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    public class Ville
    {
        /// <summary>
        /// Nom de la ville
        /// </summary>
        public string Nom { get; private set; }

        /// <summary>
        /// Liste de batiments dans cette ville
        /// </summary>
        public List<Batiment> Listebatiments { get; private set; }

        /// <summary>
        /// Constructeur de la class Ville
        /// </summary>
        /// <param name="nom">Nom de la ville</param>
        public Ville (string nom)
        {
            Nom = nom;
            Listebatiments = new List<Batiment>();
        }
        
        /// <summary>
        /// Ajouter un batiment à cette ville
        /// </summary>
        /// <param name="nom">Nom du batiment</param>
        /// <param name="architecte">Nom de l'architecte du batiment</param>
        /// <param name="description">Description du batiment</param>
        /// <returns></returns>
        public bool AjouterBatiment ( string nom, string architecte, string description)
        {
            Batiment batiment = new Batiment(nom, architecte, description);
            Listebatiments.Add(batiment);
            return true;
        }


    }
}
