using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    public class Manager
    {
        public List<Ville> Listevilles { get; private set; } //liste des villes contenues dans l'application

        //------------------------------------------------------------------------------------//
        //CONSTRUCTEURS

        /// <summary>
        /// Constructeur de la classe Manager
        /// </summary>
        public Manager()
        {
            Listevilles = new List<Ville>();
        }

        //------------------------------------------------------------------------------------//
        //METHODES

        /// <summary>
        /// Ajouter une ville dans la liste de villes
        /// </summary>
        /// <returns>Retourne true si la liste a bien été ajoutée à la liste sinon retourne false</returns>
        public bool AjouterVille (string nom)
        {
            Ville ville = new Ville(nom);
            Listevilles.Add(ville);
            if (Listevilles.Contains(ville)) return true;
            else return false;
        }

        /// <summary>
        /// Supprime une ville de la liste avec un nom donné
        /// </summary>
        /// <returns>Retourne true si la ville n'est plus présente dans la liste des villes sinon retourne false</returns>
        public bool SupprimerVille (string nom)
        {
            Ville ville = new Ville(nom);
            Listevilles.Remove(ville);
            if (Listevilles.Contains(ville)) return false;
            else return true;
        }

        /// <summary>
        /// Recherche une ville grâce à un nom de ville donné
        /// </summary>
        /// <returns>Retourne la position où se trouve la ville dans la liste</returns>
        public int RechercherVille(string nomville)
        {
            Ville ville = new Ville(nomville);
            int index = Listevilles.IndexOf(ville);
            return index;
        }

        /// <summary>
        /// Modifier une ville dans la liste
        /// </summary>
        /// <returns>Retourne true si les modifications ont bien été opérées sinon retourne false</returns>
        public bool ModifierVille(string nomville, string nvnomville)
        {
            int index = RechercherVille(nomville);
            Listevilles[index].Nom = nvnomville;
            if (Listevilles[index].Nom == nvnomville) return true;
            else return false;
        }

        /// <summary>
        /// Ajout d'un batiment avec détail simple dans une ville donnée
        /// </summary>
        /// <returns>Retourne true si le batiment a été ajouté dans la liste sinon retourne false</returns>
        public bool AjouterBatimentSimple(string nomville, string nombat, string pays, string ville, string description)
        {
            bool res = Listevilles[RechercherVille(nomville)].AjouterBatimentSimple(nombat, pays, ville, description);
            return res;
        }

        /// <summary>
        /// Ajout d'un batiment avec détail complet dans une ville donnée
        /// </summary>
        /// <returns>Retourne true si l'ajout du batiment à bien eu lieu sinon retourne false</returns>
        public bool AjouterBatimentComplet(string nomville, string nombat, string pays, string ville, string quartier, 
            string adresse, string architecte, string ingenieur, string style, string materiaux, string hauteur, 
            string nbetages, string construction, string ouverture, string description)
        {
            bool res = Listevilles[RechercherVille(nomville)].AjouterBatimentComplet(nombat, pays, ville, quartier, adresse, architecte, ingenieur
                , style, materiaux, hauteur, nbetages, construction, ouverture, description);
            return res;
        }

        /// <summary>
        /// Supprimer un batiment dans une ville donnée
        /// </summary>
        /// <returns>Retourne true si le batiment n'est plus présent dans la liste sinon retourne false</returns>
        public bool SupprimerBatiment (string nomville, string nombat)
        {
            Batiment batiment = new Batiment(nombat);
            bool res = Listevilles[RechercherVille(nomville)].Listebatiments.Remove(batiment);
            return res;
        }

        /// <summary>
        /// Modifier un batiment dans une ville donnée
        /// </summary>
        /// <returns>Retourne true si les modifications ont bien été opérées sinon retourne false</returns>
        public bool ModifierBatiment( string nomville, string nombat, string nvnom, string pays, string ville, string quartier,
            string adresse, string architecte, string ingenieur, string style, string materiaux, string hauteur,
            string nbetages, string construction, string ouverture, string description)
        {
            bool res = Listevilles[RechercherVille(nomville)].ModifierBatiment(nombat, nvnom, pays, ville, quartier, adresse,
                architecte, ingenieur, style, materiaux, hauteur, nbetages, construction, ouverture, description);
            return res;
        }

        //------------------------------------------------------------------------------------//
        //REDEFINITION DE METHODES

        public override string ToString()
        {
            string message = "///---Affichage de toutes les données des villes contenues dans l'application:---///\n\n";
            foreach(Ville ville in Listevilles)
            {
                message += ville.ToString();
            }
            return message;
        }
    }
}
