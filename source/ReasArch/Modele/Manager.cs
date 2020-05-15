using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    class Manager
    {
        public List<Ville> Listevilles { get; private set; }

        //------------------------------------------------------------------------------------//
        //CONSTRUCTEURS

        public Manager()
        {
            Listevilles = new List<Ville>();
        }

        //------------------------------------------------------------------------------------//
        //METHODES

        /// <summary>
        /// Ajouter une ville dans la liste de villes
        /// </summary>
        /// <returns>Retourne true si la liste a bien été ajoutée à la liste</returns>
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
        /// <returns>Retourne true si la ville n'est plus présente dans la liste des villes</returns>
        public bool SupprimerVille (string nom)
        {
            Ville ville = new Ville(nom);
            Listevilles.Remove(ville);
            if (Listevilles.Contains(ville)) return false;
            else return true;
        }

        /// <summary>
        /// Modifier une ville dans la liste
        /// </summary>
        /// <returns>Retourne true si les modifications ont bien été opérées</returns>
        public bool ModifierVille (string nom)
        {
            int index;
            Ville v = new Ville(nom);
            index = Listevilles.IndexOf(v);
            Listevilles[index].Nom = nom;
            if (Listevilles[index].Nom == nom) return true;
            else return false;
        }

        /// <summary>
        /// Ajout d'un batiment avec détail simple dans une ville donnée
        /// </summary>
        /// <returns>Retourne true si le batiment a été ajouté dans la liste</returns>
        public bool AjouterBatimentSimple(string nomville, string nombat, string pays, string ville, string description)
        {
            bool res;
            int index;
            Ville v = new Ville(nomville);
            index = Listevilles.IndexOf(v);
            res = Listevilles[index].AjouterBatimentSimple(nombat, pays, ville, description);
            return res;
        }

        /// <summary>
        /// Ajout d'un batiment avec détail complet dans une ville donnée
        /// </summary>
        /// <returns></returns>
        public bool AjouterBatimentComplet(string nomville, string nombat, string pays, string ville, string quartier, 
            string adresse, string architecte, string ingenieur, string style, string materiaux, string hauteur, 
            string nbetages, string construction, string ouverture, string description)
        {
            bool res;
            int index;
            Ville v = new Ville(nomville);
            index = Listevilles.IndexOf(v);
            res = Listevilles[index].AjouterBatimentComplet(nombat, pays, ville, quartier, adresse, architecte, ingenieur
                , style, materiaux, hauteur, nbetages, construction, ouverture, description);
            return res;
        }

        /// <summary>
        /// Supprimer un batiment dans une ville donnée
        /// </summary>
        /// <returns>Retourne true si le batiment n'est plus présent dans la liste</returns>
        public bool SupprimerBatiment (string nomville, string nombat)
        {
            bool res;
            int index;
            Ville ville = new Ville(nomville);
            Batiment batiment = new Batiment(nombat);
            index = Listevilles.IndexOf(ville);
            res = Listevilles[index].Listebatiments.Remove(batiment);
            return res;
        }

        /// <summary>
        /// Modifier un batiment dans une ville donnée
        /// </summary>
        /// <returns>Retourne true si les modifications ont bien été opérées</returns>
        public bool ModifierBatiment( string nomville, string nombat)
        {
            return true;
        }
    }
}
