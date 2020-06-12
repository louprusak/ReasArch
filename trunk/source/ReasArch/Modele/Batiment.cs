using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace Modele
{
    public class Batiment
    {
        public string Nom { get; set; } //Nom du batiment
        public string Pays { get; set; } = "non spécifié"; //Pays dans lequel se trouve le batiment
        public string Ville { get; set; } = "non spécifié";//Ville dans laquelle se trouve le batiment
        public string Quartier { get; set; } = "non spécifié";//Quartier dans lequel se trouve la batiment
        public string Adresse { get; set; } = "non spécifié";//Adresse du batiment
        public string Architecte { get; set; } = "non spécifié";//Architecte du batiment
        public string Ingenieur { get; set; } = "non spécifié";//INgénieur du batiment
        public string Style { get; set; } = "non spécifié";//Style du batiment
        public string Materiaux { get; set; } = "non spécifié";//Matériaux utilisés pour construire le batiment
        public string Hauteur { get; set; } = "non spécifié";//Hauteur en mètres du batiment
        public string NbEtages { get; set; } = "non spécifié";//Nombre d'étages du batiment
        public string Construction { get; set; } = "non spécifié";//Années de construction du batiment
        public string Ouverture { get; set; } = "non spécifié";//Année d'ouverture du batiment
        public string Description { get; set; } = "aucune description";//Description autre du batiment
        public string ImagePrincipale { get; set; } = null;//Image Principale du batiment
        public string ImageArchitecte { get; set; } = null;//Image de l'architecte du batiment
        public string ImagePlan { get; set; } = null;//Image du plan du batiment
        public string ImageInterieur { get; set; } = null;//Image de l'intérieur du batiment

        //----------------------------------------------------------------------------------------------------------------------//
        //CONSTRUCTEURS

        /// <summary>
        /// Constructeur de la class Batiment
        /// </summary>
        public Batiment(string nom)
        {
            Nom = nom;
        }

        /// <summary>
        /// Constructeur de la class Batiment
        /// </summary>
        public Batiment(string nom, string pays, string ville, string description, string imageprincipale, string imagearchitecte, string imageplan, string imageinterieur)
        {
            if (!String.IsNullOrEmpty(nom) | !String.IsNullOrEmpty(pays) | !String.IsNullOrEmpty(ville) | String.IsNullOrEmpty(description))
            {
                Nom = nom;
                Pays = pays;
                Ville = ville;
                Description = description;
                ImagePrincipale = imageprincipale;
                ImageArchitecte = imagearchitecte;
                ImagePlan = imageplan;
                ImageInterieur = imageinterieur;
            }
            else throw new ArgumentException();
        }

        /// <summary>
        /// Constructeur de la class Batiment
        /// </summary>
        public Batiment(string nom, string pays, string ville, string quartier, string adresse, string architecte,
            string ingenieur, string style, string materiaux, string hauteur, string nbetages, string construction,
            string ouverture, string description, string imageprincipale, string imagearchitecte, 
            string imageplan, string imageinterieur) : this(nom, pays, ville, description, imageprincipale, imagearchitecte, imageplan, imageinterieur)
        {
            Quartier = quartier;
            Adresse = adresse;
            Architecte = architecte;
            Ingenieur = ingenieur;
            Style = style;
            Materiaux = materiaux;
            Hauteur = hauteur;
            NbEtages = nbetages;
            Construction = construction;
            Ouverture = ouverture;
        }

        //------------------------------------------------------------------------------------//
        //METHODES

        /// <summary>
        /// Modifie les paramètres d'un batiment
        /// </summary>
        /// <returns>Retourne true si la modification a bien eu lieu sinon retourne false</returns>
        public bool ModifierBatiment(string nvnom, string pays, string ville, string quartier,
            string adresse, string architecte, string ingenieur, string style, string materiaux, string hauteur,
            string nbetages, string construction, string ouverture, string description, string imageprincipale,
            string imagearchitecte, string imageplan, string imageinterieur)
        {
            Nom = nvnom; Pays = pays; Ville = ville;  Quartier = quartier; Adresse = adresse;
            Architecte = architecte; Ingenieur = ingenieur; Style = style; Materiaux = materiaux;
            Hauteur = hauteur; NbEtages = nbetages; Construction = construction;
            Ouverture = ouverture; Description = description; ImagePrincipale = imageprincipale;
            ImageArchitecte = imagearchitecte; ImagePlan = imageplan; ImageInterieur = imageinterieur;

            if(Nom == nvnom && Pays == pays && Ville == ville && Quartier == quartier && Adresse == adresse &&
            Architecte == architecte && Ingenieur == ingenieur && Style == style && Materiaux == materiaux &&
            Hauteur == hauteur && NbEtages == nbetages && Construction == construction &&
            Ouverture == ouverture && Description == description) return true;
            else return false;
        }

        //----------------------------------------------------------------------------------------------------------------------//
        //REDEFINITION DE METHODES 

        /// <summary>
        /// Définit l'affichage de la description du batiment
        /// </summary>
        /// <returns>Retourne le message à afficher</returns>
        public override string ToString()
        {
            string message = $"Nom : {Nom}\nPays : {Pays}\nQuartier : {Quartier}\nAdresse : {Adresse}\nArchitecte : {Architecte}\n" +
                $"Ingénieur : {Ingenieur}\nStyle : {Style}\nMatériaux : {Materiaux}\nHauteur : {Hauteur}\nNombre d'Etages : {NbEtages}\n" +
                $"Construction : {Construction}\nOuverture : {Ouverture}\n\n" +
                $"{Description}\n\n";
            return message;
        }

        /// <summary>
        /// Compare si l'objet envoyé est le même que le batiment  
        /// </summary>
        /// <returns>Retourne true si ce sont tout deux le même batiment</returns>
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (this == obj) return true;
            if (this.GetType() != obj.GetType()) return false;
            Batiment other = (Batiment)obj;
            return Nom.Equals(other.Nom);
        }
    }
}

