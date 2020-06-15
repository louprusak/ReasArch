using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Modele
{
    /// <summary>
    /// Classe Monde de l'application : c'est elle qui contient la liste des villes de l'application et qui pourra modifier ces éléments
    /// </summary>
    public class Monde
    {
        /// <summary>
        /// Liste des villes contenues dans l'application
        /// </summary>
        public ObservableCollection<Ville> Listevilles
        {
            get { return listevilles; }
            set { listevilles = value; }
        }
        private ObservableCollection<Ville> listevilles;


        //------------------------------------------------------------------------------------//
        //CONSTRUCTEURS


        /// <summary>
        /// Constructeur de la classe Monde avec initialisation de la liste des villes
        /// </summary>
        public Monde()
        {
            listevilles = new ObservableCollection<Ville>();
        }


        //------------------------------------------------------------------------------------//
        //METHODES


        /// <summary>
        /// Permet d'ajouter une ville dans la liste des villes
        /// </summary>
        /// <returns> Retourne true si la ville a bien été ajoutée à la liste sinon retourne false</returns>
        public bool AjouterVille (string nom, string pays, string imagevignette, string imagepanorama)
        {
            Ville ville = new Ville(nom, pays, imagevignette, imagepanorama);
            Listevilles.Add(ville);
            if (Listevilles.Contains(ville)) return true;
            else return false;
        }

        /// <summary>
        /// Permet de supprimer une ville de la liste des villes en fonction du nom donné
        /// </summary>
        /// <returns> Retourne true si la ville n'est plus présente dans la liste des villes sinon retourne false</returns>
        public bool SupprimerVille (string nom)
        {
            Ville ville = new Ville(nom);
            Listevilles.Remove(ville);
            if (Listevilles.Contains(ville)) return false;
            else return true;
        }

        /// <summary>
        /// Recherche une ville grâce à son nom
        /// </summary>
        /// <returns> Retourne la position où se trouve la ville dans la liste</returns>
        public int RechercherVille(string nomville)
        {
            Ville ville = new Ville(nomville);
            int index = Listevilles.IndexOf(ville);
            return index;
        }

        /// <summary>
        /// Ajout d'un batiment avec détail simple dans une ville de nom donné
        /// </summary>
        /// <returns> Retourne true si le batiment a été ajouté dans la liste des batiments de la ville sinon retourne false</returns>
        public bool AjouterBatimentSimple(string nomville, string nombat, string description, string imageprincipale, string imagearchitecte, string imageplan, string imageinterieur)
        {
            bool res = Listevilles[RechercherVille(nomville)].AjouterBatimentSimple(nombat, description, imageprincipale, imagearchitecte, imageplan, imageinterieur);
            return res;
        }

        /// <summary>
        /// Ajout d'un batiment avec détail complet dans une ville de nom donné
        /// </summary>
        /// <returns> Retourne true si l'ajout du batiment à bien eu lieu sinon retourne false</returns>
        public bool AjouterBatimentComplet(string nomville, string nombat, string quartier, 
            string adresse, string architecte, string ingenieur, string style, string materiaux, string hauteur, 
            string nbetages, string construction, string ouverture, string description, string imageprincipale, string imagearchitecte, string imageplan, string imageinterieur)
        {
            Modele.Ville v = Listevilles[RechercherVille(nomville)];
            bool res = v.AjouterBatimentComplet(nombat, quartier, adresse, architecte, ingenieur
                , style, materiaux, hauteur, nbetages, construction, ouverture, description, imageprincipale, imagearchitecte, imageplan, imageinterieur);
            return res;
        }

        /// <summary>
        /// Supprimer un batiment de nom donné dans une ville de nom donné
        /// </summary>
        /// <returns> Retourne true si le batiment n'est plus présent dans la liste de batiments de la ville, sinon retourne false</returns>
        public bool SupprimerBatiment (string nomville, string nombat)
        {
            Batiment batiment = new Batiment(nombat);
            bool res = Listevilles[RechercherVille(nomville)].Listebatiments.Remove(batiment);
            return res;
        }


        //------------------------------------------------------------------------------------//
        //REDEFINITION DE METHODES

        /// <summary>
        /// Redéfinition du ToString de la classe Monde
        /// </summary>
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
