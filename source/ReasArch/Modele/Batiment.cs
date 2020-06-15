using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;

namespace Modele
{
    /// <summary>
    /// Classe Batiment de l'application c'est l'élément de présentation essentiel de l'application
    /// </summary>
    [DataContract]
    public class Batiment : INotifyPropertyChanged
    {
        /// <summary>
        /// Nom du Batiment
        /// </summary>
        [DataMember]
        public String Nom
        {
            get { return nom; }
            set {
                if (nom != value)
                { nom = value;OnPropertyChanged();}
            }
        }
        private String nom;

        /// <summary>
        /// Pays dans lequel se trouve le Batiment
        /// </summary>
        [DataMember]
        public String Pays
        {
            get { return pays; }
            set {
                if (pays != value)
                { pays = value; OnPropertyChanged(); }
            }
        }
        private string pays = "non spécifié";

        /// <summary>
        /// Ville dans laquelle se trouve le batiment
        /// </summary>
        [DataMember]
        public String Ville
        {
            get { return ville; }
            set {
                if (ville != value)
                { ville = value; OnPropertyChanged(); }
            }
        }
        private string ville = "non spécifié";

        /// <summary>
        /// Quartier de la ville dans lequel se trouve le batiment
        /// </summary>
        [DataMember]
        public String Quartier
        {
            get { return quartier; }
            set {
                if (quartier != value)
                { quartier= value; OnPropertyChanged(); }
            }
        }
        private string quartier = "non spécifié";

        /// <summary>
        /// Adresse à laquelle se trouve le batiment
        /// </summary>
        [DataMember]
        public String Adresse
        {
            get { return adresse; }
            set {
                if (adresse != value)
                { adresse = value; OnPropertyChanged(); }
            }
        }
        private string adresse = "non spécifié";

        /// <summary>
        /// Architecte du Batiment
        /// </summary>
        [DataMember]
        public String Architecte
        {
            get { return architecte; }
            set {
                if (architecte != value)
                { architecte = value; OnPropertyChanged(); }
            }
        }
        private string architecte = "non spécifié";

        /// <summary>
        /// Ingénieur du batiment
        /// </summary>
        [DataMember]
        public String Ingenieur
        {
            get { return ingenieur; }
            set {
                if (ingenieur != value)
                { ingenieur = value; OnPropertyChanged(); }
            }
        }
        private string ingenieur = "non spécifié";

        /// <summary>
        /// Style architectural du batiment
        /// </summary>
        [DataMember]
        public String Style
        {
            get { return style; }
            set {
                if (style != value)
                { style = value; OnPropertyChanged(); }
            }
        }
        private string style = "non spécifié";

        /// <summary>
        /// Matériaux utilisés pour construire le batiment
        /// </summary>
        [DataMember]
        public String Materiaux
        {
            get { return materiaux; }
            set {
                if (materiaux != value)
                { materiaux = value; OnPropertyChanged(); }
            }
        }
        private string materiaux = "non spécifié";

        /// <summary>
        /// Hauteur en mètres du batiment
        /// </summary>
        [DataMember]
        public String Hauteur
        {
            get { return hauteur; }
            set {
                if (hauteur != value)
                { hauteur = value; OnPropertyChanged(); }
            }
        }
        private string hauteur = "non spécifié";

        /// <summary>
        /// Nombre d'étages du batiment
        /// </summary>
        [DataMember]
        public String Nbetages
        {
            get { return nbetages; }
            set {
                if (nbetages != value)
                { nbetages = value; OnPropertyChanged(); }
            }
        }
        private string nbetages = "non spécifié";

        /// <summary>
        /// Années de construction du batiment
        /// </summary>
        [DataMember]
        public String Construction
        {
            get { return construction; }
            set {
                if (construction != value)
                { construction = value; OnPropertyChanged(); }
            }
        }
        private string construction = "non spécifié";

        /// <summary>
        /// Année d'ouverture du batiment
        /// </summary>
        [DataMember]
        public String Ouverture
        {
            get { return ouverture; }
            set {
                if (ouverture != value)
                { ouverture = value; OnPropertyChanged(); }
            }
        }
        private string ouverture = "non spécifié";

        /// <summary>
        /// Description du batiment
        /// </summary>
        [DataMember]
        public String Description
        {
            get { return description; }
            set {
                if (description != value)
                { description = value; OnPropertyChanged(); }
            }
        }
        private string description = "aucune Description";

        /// <summary>
        /// Image principale du batiment
        /// </summary>
        [DataMember]
        public String Imageprincipale
        {
            get { return imageprincipale; }
            set {
                if (imageprincipale != value)
                { imageprincipale = value; OnPropertyChanged(); }
            }
        }
        private string imageprincipale = null;

        /// <summary>
        /// Image de l'architecte du batiment
        /// </summary>
        [DataMember]
        public String Imagearchitecte
        {
            get { return imagearchitecte; }
            set {
                if (imagearchitecte != value)
                { imagearchitecte = value; OnPropertyChanged(); }
            }
        }
        private string imagearchitecte = null;

        /// <summary>
        /// Image du plan du batiment
        /// </summary>
        [DataMember]
        public String Imageplan
        {
            get { return imageplan; }
            set {
                if (imageplan != value)
                { imageplan= value; OnPropertyChanged(); }
            }
        }
        private string imageplan = null;

        /// <summary>
        /// Image de l'interieur du batiment
        /// </summary>
        [DataMember]
        public String Imageinterieur
        {
            get { return imageinterieur; }
            set {
                if (imageinterieur != value)
                { imageinterieur = value; OnPropertyChanged(); }
            }
        }
        private string imageinterieur = null;


        //----------------------------------------------------------------------------------------------------------------------//
        //CONSTRUCTEURS


        /// <summary>
        /// Constructeur de la classe Batiment avec le nom
        /// </summary>
        public Batiment(string nom)
        {
            Nom = nom;
        }

        /// <summary>
        /// Constructeur simple de la classe Batiment
        /// </summary>
        public Batiment(string nom, string pays, string ville, string description, string imageprincipale, string imageArchitecte, 
            string imageplan, string imageinterieur):this(nom)
        {
            Pays = pays;
            Ville = ville;
            Description = description;
            Imageprincipale = imageprincipale;
            Imagearchitecte = imageArchitecte;
            Imageplan = imageplan;
            Imageinterieur = imageinterieur;
        }

        /// <summary>
        /// Constructeur complet de la classe Batiment
        /// </summary>
        public Batiment(string nom, string pays, string ville, string quartier, string adresse, string architecte,
            string ingenieur, string style, string materiaux, string hauteur, string nbetages, string construction,
            string ouverture, string description, string imageprincipale, string imageArchitecte, 
            string imageplan, string imageinterieur) : this(nom, pays, ville, description, imageprincipale, imageArchitecte, imageplan, imageinterieur)
        {
            Quartier = quartier;
            Adresse = adresse;
            Architecte = architecte;
            Ingenieur = ingenieur;
            Style = style;
            Materiaux = materiaux;
            Hauteur = hauteur;
            Nbetages = nbetages;
            Construction = construction;
            Ouverture = ouverture;
        }


        //----------------------------------------------------------------------------------------------------------------------//
        //REDEFINITION DE METHODES 


        /// <summary>
        /// Définit l'affichage de la Description du batiment
        /// </summary>
        /// <returns>Retourne le message à afficher</returns>
        public override string ToString()
        {
            string message = $"Nom : {Nom}\nPays : {Pays}\nVille : {Ville}\nQuartier : {Quartier}\nAdresse : {Adresse}\nArchitecte : {Architecte}\n" +
                $"Ingénieur : {Ingenieur}\nStyle : {Style}\nMatériaux : {Materiaux}\nHauteur : {Hauteur}\nNombre d'Etages : {Nbetages}\n" +
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

        /// <summary>
        /// Event de changement de propriété
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Méthode appelée lors du changement de propriété des objects afin de refaire remonter l'information et ainsi de modifier le visuel XAML
        /// </summary>
        void OnPropertyChanged([CallerMemberName]string PropertyName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
    }
}

