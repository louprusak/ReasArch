using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;
using System.Text;

namespace Modele
{
    public class Batiment : INotifyPropertyChanged
    {
        public String Nom
        {
            get { return nom; }
            set {
                if (nom != value)
                { nom = value;OnPropertyChanged();}
            }
        }
        private String nom; //Nom du batiment

        public String Pays
        {
            get { return pays; }
            set {
                if (pays != value)
                { pays = value; OnPropertyChanged(); }
            }
        }
        private string pays = "non spécifié"; //Pays dans lequel se trouve le batiment

        public String Ville
        {
            get { return ville; }
            set {
                if (ville != value)
                { ville = value; OnPropertyChanged(); }
            }
        }
        private string ville = "non spécifié";//Ville dans laquelle se trouve le batiment

        public String Quartier
        {
            get { return quartier; }
            set {
                if (quartier != value)
                { quartier= value; OnPropertyChanged(); }
            }
        }
        private string quartier = "non spécifié";//Quartier dans lequel se trouve la batiment

        public String Adresse
        {
            get { return adresse; }
            set {
                if (adresse != value)
                { adresse = value; OnPropertyChanged(); }
            }
        }
        private string adresse = "non spécifié";//Adresse du batiment

        public String Architecte
        {
            get { return architecte; }
            set {
                if (architecte != value)
                { architecte = value; OnPropertyChanged(); }
            }
        }
        private string architecte = "non spécifié";//Architecte du batiment

        public String Ingenieur
        {
            get { return ingenieur; }
            set {
                if (ingenieur != value)
                { ingenieur = value; OnPropertyChanged(); }
            }
        }
        private string ingenieur = "non spécifié";//INgénieur du batiment

        public String Style
        {
            get { return style; }
            set {
                if (style != value)
                { style = value; OnPropertyChanged(); }
            }
        }
        private string style = "non spécifié";//Style du batiment

        public String Materiaux
        {
            get { return materiaux; }
            set {
                if (materiaux != value)
                { materiaux = value; OnPropertyChanged(); }
            }
        }
        private string materiaux = "non spécifié";//Matériaux utilisés pour construire le batiment

        public String Hauteur
        {
            get { return hauteur; }
            set {
                if (hauteur != value)
                { hauteur = value; OnPropertyChanged(); }
            }
        }
        private string hauteur = "non spécifié";//Hauteur en mètres du batiment

        public String Nbetages
        {
            get { return nbetages; }
            set {
                if (nbetages != value)
                { nbetages = value; OnPropertyChanged(); }
            }
        }
        private string nbetages = "non spécifié";//Nombre d'étages du batiment

        public String Construction
        {
            get { return construction; }
            set {
                if (construction != value)
                { construction = value; OnPropertyChanged(); }
            }
        }
        private string construction = "non spécifié";//Années de Construction du batiment

        public String Ouverture
        {
            get { return ouverture; }
            set {
                if (ouverture != value)
                { ouverture = value; OnPropertyChanged(); }
            }
        }
        private string ouverture = "non spécifié";//Année d'Ouverture du batiment

        public String Description
        {
            get { return description; }
            set {
                if (description != value)
                { description = value; OnPropertyChanged(); }
            }
        }
        private string description = "aucune Description";//Description autre du batiment

        public String Imageprincipale
        {
            get { return imageprincipale; }
            set {
                if (imageprincipale != value)
                { imageprincipale = value; OnPropertyChanged(); }
            }
        }
        private string imageprincipale = null;//Image Principale du batiment

        public String Imagearchitecte
        {
            get { return imagearchitecte; }
            set {
                if (imagearchitecte != value)
                { imagearchitecte = value; OnPropertyChanged(); }
            }
        }
        private string imagearchitecte = null;//Image de l'Architecte du batiment

        public String Imageplan
        {
            get { return imageplan; }
            set {
                if (imageplan != value)
                { imageplan= value; OnPropertyChanged(); }
            }
        }
        private string imageplan = null;//Image du plan du batiment

        public String Imageinterieur
        {
            get { return imageinterieur; }
            set { imageinterieur = value; }
        }
        private string imageinterieur = null;//Image de l'intérieur du batiment


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
        public Batiment(string nom, string pays, string ville, string description, string imageprincipale, string imageArchitecte, string imageplan, string imageinterieur)
        {
            if (!String.IsNullOrEmpty(Nom) | !String.IsNullOrEmpty(pays) | !String.IsNullOrEmpty(Ville) | String.IsNullOrEmpty(Description))
            {
                Nom = nom;
                Pays = pays;
                Ville = ville;
                Description = description;
                Imageprincipale = imageprincipale;
                Imagearchitecte = imageArchitecte;
                Imageplan = imageplan;
                Imageinterieur = imageinterieur;
            }
            else throw new ArgumentException();
        }


        /// <summary>
        /// Constructeur de la class Batiment
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
            Hauteur = hauteur; Nbetages = nbetages; Construction = construction;
            Ouverture = ouverture; Description = description; Imageprincipale = imageprincipale;
            Imagearchitecte = imagearchitecte; Imageplan = imageplan; Imageinterieur = imageinterieur;

            if(Nom == nvnom && Pays == pays && Ville == ville && Quartier == quartier && Adresse == adresse &&
            Architecte == architecte && Ingenieur == ingenieur && Style == style && Materiaux == materiaux &&
            Hauteur == hauteur && Nbetages == nbetages && Construction == construction &&
            Ouverture == ouverture && Description == description) return true;
            else return false;
        }


        //----------------------------------------------------------------------------------------------------------------------//
        //REDEFINITION DE METHODES 

        /// <summary>
        /// Définit l'affichage de la Description du batiment
        /// </summary>
        /// <returns>Retourne le message à afficher</returns>
        public override string ToString()
        {
            string message = $"Nom : {Nom}\nPays : {Pays}\nQuartier : {Quartier}\nAdresse : {Adresse}\nArchitecte : {Architecte}\n" +
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

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Méthode appelée lors du changement de propriété des objects afin de refaire remonter l'information et ainsi de modifier le visuel XAML
        /// </summary>
        void OnPropertyChanged([CallerMemberName]string PropertyName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
    }
}

