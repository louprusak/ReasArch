using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace Modele
{
    public class Batiment
    {
        public string Nom { get => Nom.ToUpper(); private set { } } //Nom du batiment
        public string Pays { get; private set; }//Pays dans lequel se trouve le batiment
        public string Ville { get; private set; }//Ville dans laquelle se trouve le batiment
        public string Quartier { get; private set; } = "non spécifié";//Quartier dans lequel se trouve la batiment
        public string Adresse { get; private set; } = "non spécifié";//Adresse du batiment
        public string Architecte { get; private set; } = "non spécifié";//Architecte du batiment
        public string Ingenieur { get; private set; } = "non spécifié";//INgénieur du batiment
        public string Style { get; private set; } = "non spécifié";//Style du batiment
        public string Materiaux { get; private set; } = "non spécifié";//Matériaux utilisés pour construire le batiment
        public string Hauteur { get; private set; } = "non spécifié";//Hauteur en mètres du batiment
        public string NbEtages { get; private set; } = "non spécifié";//Nombre d'étages du batiment
        public string Construction { get; private set; } = "non spécifié";//Années de construction du batiment
        public string Ouverture { get; private set; } = "non spécifié";//Année d'ouverture du batiment
        public string Description { get; private set; }//Description autre du batiment

        //----------------------------------------------------------------------------------------------------------------------//
        //CONSTRUCTEURS

        public Batiment(string nom)
        {
            Nom = nom;
        }

        public Batiment(string nom, string pays, string ville, string description)
        {
            if (!String.IsNullOrEmpty(nom) | !String.IsNullOrEmpty(pays) | !String.IsNullOrEmpty(ville) | String.IsNullOrEmpty(description))
            {
                Nom = nom;
                Pays = pays;
                Ville = ville;
                Description = description;
            }
        }


        public Batiment(string nom, string pays, string ville, string quartier, string adresse, string architecte,
            string ingenieur, string style, string materiaux, string hauteur, string nbetages, string construction,
            string ouverture, string description)
            : this(nom, pays, ville, description)
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

        //----------------------------------------------------------------------------------------------------------------------//
        //METHODES  

        public override string ToString()
        {
            string message = $"Nom : {Nom}\nPays : {Pays}\nQuartier : {Quartier}\nAdresse : {Adresse}\nArchitecte : {Architecte}\n" +
                $"Ingénieur : {Ingenieur}\nStyle : {Style}\nMatériaux : {Materiaux}\nHauteur : {Hauteur}\nNombre d'Etages : {NbEtages}\n" +
                $"Construction : {Construction}\nOuverture : {Ouverture}\n\n" +
                $"{Description}";
            return message;
        }

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

