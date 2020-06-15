using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;

namespace Modele
{
    /// <summary>
    /// Classe ville de l'application et du master, elle contient une liste de batiments
    /// </summary>
    [DataContract]
    public class Ville : INotifyPropertyChanged
    {
        /// <summary>
        /// Liste des batiment contenus dans la ville
        /// </summary>
        [DataMember]
        public ObservableCollection<Batiment> Listebatiments
        {
            get { return listebatiments; }
            set { listebatiments = value; }
        }
        private ObservableCollection<Batiment> listebatiments;

        /// <summary>
        /// Nom de la ville
        /// </summary>
        [DataMember]
        public string Nom
        {
            get { return nom; }
            set {
                if (nom != value)
                { nom = value; OnPropertyChanged(); }
            }
        }
        private string nom;

        /// <summary>
        /// Pays dans lequel se trouve la ville
        /// </summary>
        [DataMember]
        public string Pays
        {
            get { return pays; }
            set {
                if (pays != value)
                { pays = value; OnPropertyChanged(); }
            }
        }
        private string pays;

        /// <summary>
        /// Image Vignette de la ville
        /// </summary>
        [DataMember]
        public string Imagevignette
        {
            get { return imagevignette; }
            set {
                if (imagevignette != value)
                { imagevignette= value; OnPropertyChanged(); }
            }
        }
        private string imagevignette = null;

        /// <summary>
        /// Image Panorama de la ville
        /// </summary>
        [DataMember]
        public string Imagepanorama
        {
            get { return imagepanorama; }
            set {
                if (imagepanorama != value)
                { imagepanorama = value; OnPropertyChanged(); }
            }
        }
        private string imagepanorama = null;

        /// <summary>
        /// Event de changement de propriété des objets
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;


        //-----------------------------------------------------------------------------------------------------------//
        //CONSTRUCTEURS


        /// <summary>
        /// Constructeur simple de la classe Modele.Ville avec le nom
        /// </summary>
        public Ville(string nom)
        {
            Nom = nom;
            Listebatiments = new ObservableCollection<Batiment>();
        }


        /// <summary>
        /// Constructeur détaillé de la classe Modele.Ville avec le pays et les images
        /// </summary>
        public Ville (string nom, string pays, string imagevignette, string imagepanorama):this(nom)
        {
            Pays = pays;
            Imagevignette = imagevignette;
            Imagepanorama = imagepanorama;
        }


        //-----------------------------------------------------------------------------------------------------------//
        //METHODES


        /// <summary>
        /// Ajoute un batiment avec un détail simple à cette ville
        /// </summary>
        /// <returns>Retourne true si le batiment a bien été ajouté à la liste sinon retourne false</returns>
        public bool AjouterBatimentSimple(string nom, string description, string imageprincipale,
            string imagearchitecte, string imageplan, string imageinterieur)
        {
            Batiment batiment = new Batiment(nom, this.Pays, this.Nom, description, imageprincipale, imagearchitecte, imageplan, imageinterieur);
            Listebatiments.Add(batiment);
            if(Listebatiments.Contains(batiment)) { return true; }
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
            Listebatiments.Add(batiment);
            if (Listebatiments.Contains(batiment)) { return true; }
            else { return false; }
        }


        //-----------------------------------------------------------------------------------------------------------//
        //REDEFINITION DE METHODES


        /// <summary>
        /// Compare si l'objet envoyé est le même que cet instance de Modele.Ville 
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
            foreach(Batiment batiment in Listebatiments)
            {
                message += batiment.ToString();
            }
            return message;
        }

        /// <summary>
        /// Méthode appelée lors du changement de propriété des objects afin de refaire remonter l'information et ainsi de modifier le visuel XAML
        /// </summary>
        void OnPropertyChanged([CallerMemberName] string PropertyName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
    }
}
