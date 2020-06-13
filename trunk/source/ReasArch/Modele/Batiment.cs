﻿using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace Modele
{
    public class Batiment
    {
        public String NOM
        {
            get { return Nom; }
            set { Nom = value; }
        }
        private String Nom; //nom du batiment

        public String PAYS
        {
            get { return Pays; }
            set { Pays = value; }
        }
        private string Pays = "non spécifié"; //Pays dans lequel se trouve le batiment

        public String VILLE
        {
            get { return Ville; }
            set { Ville = value; }
        }
        private string Ville = "non spécifié";//Ville dans laquelle se trouve le batiment

        public String QUARTIER
        {
            get { return Quartier; }
            set { Quartier = value; }
        }
        private string Quartier = "non spécifié";//Quartier dans lequel se trouve la batiment

        public String ADRESSE
        {
            get { return Adresse; }
            set { Adresse = value; }
        }
        private string Adresse = "non spécifié";//Adresse du batiment

        public String ARCHITECTE
        {
            get { return Architecte; }
            set { Architecte = value; }
        }
        private string Architecte = "non spécifié";//Architecte du batiment

        public String INGENIEUR
        {
            get { return Ingenieur; }
            set { Ingenieur = value; }
        }
        private string Ingenieur = "non spécifié";//INgénieur du batiment

        public String STYLE
        {
            get { return Style; }
            set { Style = value; }
        }
        private string Style = "non spécifié";//Style du batiment

        public String MATERIAUX
        {
            get { return Materiaux; }
            set { Materiaux = value; }
        }
        private string Materiaux = "non spécifié";//Matériaux utilisés pour construire le batiment

        public String HAUTEUR
        {
            get { return Hauteur; }
            set { Hauteur = value; }
        }
        private string Hauteur = "non spécifié";//Hauteur en mètres du batiment

        public String NBETAGES
        {
            get { return NbEtages; }
            set { NbEtages = value; }
        }
        private string NbEtages = "non spécifié";//Nombre d'étages du batiment

        public String CONSTRUCTION
        {
            get { return Construction; }
            set { Construction = value; }
        }
        private string Construction = "non spécifié";//Années de construction du batiment

        public String OUVERTURE
        {
            get { return Ouverture; }
            set { Ouverture = value; }
        }
        private string Ouverture = "non spécifié";//Année d'ouverture du batiment

        public String DESCRIPTION
        {
            get { return Description; }
            set { Description = value; }
        }
        private string Description = "aucune description";//Description autre du batiment

        public String IMAGEPRINCIPALE
        {
            get { return ImagePrincipale; }
            set { ImagePrincipale = value; }
        }
        private string ImagePrincipale = null;//Image Principale du batiment

        public String IMAGEARCHITECTE
        {
            get { return ImageArchitecte; }
            set { ImageArchitecte = value; }
        }
        private string ImageArchitecte = null;//Image de l'architecte du batiment

        public String IMAGEPLAN
        {
            get { return ImagePlan; }
            set { ImagePlan = value; }
        }
        private string ImagePlan = null;//Image du plan du batiment

        public String IMAGEINTERIEUR
        {
            get { return ImageInterieur; }
            set { ImageInterieur = value; }
        }
        private string ImageInterieur = null;//Image de l'intérieur du batiment


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

