using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace Modele
{
    public class Ville
    {
        public string NOM
        {
            get { return Nom; }
            set { Nom = value; }
        }
        private string Nom; // nom de la ville

        public string PAYS
        {
            get { return Pays; }
            set { Pays = value; }
        }
        private string Pays; //Pays dans lequel se trouve la ville

        public string IMAGEVIGNETTE
        {
            get { return ImageVignette; }
            set { ImageVignette = value; }
        }
        private string ImageVignette = null; // Image de la vignette de la ville

        public string IMAGEPANORAMA
        {
            get { return ImagePanorama; }
            set { ImagePanorama = value; }
        }
        private string ImagePanorama = null; // Image panoramique de la ville

        public ObservableCollection<Batiment> LISTEBATIMENTS
        {
            get { return ListeBatiments; }
            set { ListeBatiments = value; }
        }
        private ObservableCollection<Batiment> ListeBatiments; // liste des batiments contenuent dans la ville


        //-----------------------------------------------------------------------------------------------------------//
        //CONSTRUCTEURS

        /// <summary>
        /// Constructeur de la class Ville sans l'image
        /// </summary>
        public Ville(string nom)
        {
            if (!String.IsNullOrEmpty(nom) | !String.IsNullOrWhiteSpace(nom))
            {
                Nom = nom;
                ListeBatiments = new ObservableCollection<Batiment>();
            }
            else throw new ArgumentException();
        }


        /// <summary>
        /// Constructeur de la class Ville avec l'image
        /// </summary>
        public Ville (string nom, string pays, string imagevignette, string imagepanorama):this(nom)
        {
            Pays = pays;
            ImageVignette = imagevignette;
            ImagePanorama = imagepanorama;
        }


        //-----------------------------------------------------------------------------------------------------------//
        //METHODES

        /// <summary>
        /// Ajouter un batiment avec un détail simple à cette ville
        /// </summary>
        /// <returns>Retourne true si le batiment a bien été ajouté à la liste sinon retourne false</returns>
        public bool AjouterBatimentSimple(string nom, string description, string imageprincipale,
            string imagearchitecte, string imageplan, string imageinterieur)
        {
            Batiment batiment = new Batiment(nom, this.Pays, this.Nom, description, imageprincipale, imagearchitecte, imageplan, imageinterieur);
            ListeBatiments.Add(batiment);
            if(ListeBatiments.Contains(batiment)) { return true; }
            else { return false; }
        }


        /// <summary>
        /// Ajouter un batiment avec un détail complet à cette ville
        /// </summary>
        /// <returns>Retourne true si le batiment a bien été ajouté à la liste sinon retourne false</returns>
        public bool AjouterBatimentComplet(string nom, string quartier, string adresse,
            string architecte, string ingenieur, string style, string materiaux, string hauteur, string nbetages,
            string construction, string ouverture, string description, string imageprincipale, string imagearchitecte, string imageplan, string imageinterieur)
        {
            Batiment batiment = new Batiment(nom, this.Pays, this.Nom, quartier, adresse, architecte, ingenieur, style, materiaux,
                hauteur, nbetages, construction, ouverture, description, imageprincipale, imagearchitecte, imageplan, imageinterieur);
            ListeBatiments.Add(batiment);
            if (ListeBatiments.Contains(batiment)) { return true; }
            else { return false; }
        }


        /// <summary>
        /// Supprime un batiment de la liste avec un nom donné
        /// </summary>
        /// <returns>Retourne true si le batiment n'est plus présent dans la liste sinon retourne false</returns>
        public bool SupprimerBatiment(string nom)
        {
            Batiment batiment = new Batiment(nom);
            ListeBatiments.Remove(batiment);
            if (ListeBatiments.Contains(batiment)){ return false; }
            else return true;
        }


        /// <summary>
        /// Recherche un batiment à partir d'un nom bonné
        /// </summary>
        /// <returns>Retourne la position où ce trouve le batiment dans la liste</returns>
        public int RechercherBatiment(string nombat)
        {
            Batiment batiment = new Batiment(nombat);
            int index = ListeBatiments.IndexOf(batiment);
            return index;
        }


        /// <summary>
        /// Modifier un batiment présent dans la liste
        /// </summary>
        /// <returns>Retourne true si le batiment à bien été modifié sinon retourne false</returns>
        public bool ModifierBatiment(string nombat, string nvnom, string pays, string ville, string quartier,
            string adresse, string architecte, string ingenieur, string style, string materiaux, string hauteur,
            string nbetages, string construction, string ouverture, string description, string imageprincipale, string imagearchitecte, string imageplan, string imageinterieur)
        {
            int index = RechercherBatiment(nombat);
            bool res = ListeBatiments[index].ModifierBatiment(nvnom, pays, ville, quartier, adresse, architecte,
                ingenieur,style, materiaux, hauteur, nbetages, construction, ouverture, description, imageprincipale, imagearchitecte, imageplan, imageinterieur);
            return res;
        }


        //-----------------------------------------------------------------------------------------------------------//
        //REDEFINITION DE METHODES

        /// <summary>
        /// Compare si l'objet envoyé est le même que la ville 
        /// </summary>
        /// <returns>Retourne true si ce sont tout deux la même ville</returns>
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (this == obj) return true;
            if (this.GetType() != obj.GetType()) return false;
            Ville other = (Ville)obj;
            return Nom.Equals(other.Nom);
        }


        /// <summary>
        /// Redéfinition du ToString de la classe ville
        /// </summary>
        /// <returns> Retourne le message à afficher </returns>
        public override string ToString()
        {
            string message = $"Description de la ville {Nom.ToUpper()} et de ses batiments :\n\n";
            foreach(Batiment batiment in ListeBatiments)
            {
                message += batiment.ToString();
            }
            return message;
        }
    }
}
