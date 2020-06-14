using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Modele
{
    public class Ville : INotifyPropertyChanged
    {
        public string Nom
        {
            get { return nom; }
            set {
                if (nom != value)
                { nom = value; OnPropertyChanged(); }
            }
        }
        private string nom; // nom de la ville

        public string Pays
        {
            get { return pays; }
            set {
                if (pays != value)
                { pays = value; OnPropertyChanged(); }
            }
        }
        private string pays; //Pays dans lequel se trouve la ville

        public string Imagevignette
        {
            get { return imagevignette; }
            set {
                if (imagevignette != value)
                { imagevignette= value; OnPropertyChanged(); }
            }
        }
        private string imagevignette = null; // Image de la vignette de la ville

        public string Imagepanorama
        {
            get { return imagepanorama; }
            set {
                if (imagepanorama != value)
                { imagepanorama = value; OnPropertyChanged(); }
            }
        }
        private string imagepanorama = null; // Image panoramique de la ville

        public ObservableCollection<Batiment> Listebatiments
        {
            get { return listebatiments; }
            set { listebatiments = value; }
        }
        private ObservableCollection<Batiment> listebatiments; // liste des batiments contenuent dans la ville

        public event PropertyChangedEventHandler PropertyChanged;


        //-----------------------------------------------------------------------------------------------------------//
        //CONSTRUCTEURS

        /// <summary>
        /// Constructeur de la class Ville sans l'image
        /// </summary>
        public Ville(string nom)
        {
            Nom = nom;
            Listebatiments = new ObservableCollection<Batiment>();
        }


        /// <summary>
        /// Constructeur de la class Ville avec l'image
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
        /// Ajouter un batiment avec un détail simple à cette ville
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


        /// <summary>
        /// Supprime un batiment de la liste avec un nom donné
        /// </summary>
        /// <returns>Retourne true si le batiment n'est plus présent dans la liste sinon retourne false</returns>
        public bool SupprimerBatiment(string nom)
        {
            Batiment batiment = new Batiment(nom);
            Listebatiments.Remove(batiment);
            if (Listebatiments.Contains(batiment)){ return false; }
            else return true;
        }


        /// <summary>
        /// Recherche un batiment à partir d'un nom bonné
        /// </summary>
        /// <returns>Retourne la position où ce trouve le batiment dans la liste</returns>
        public int RechercherBatiment(string nombat)
        {
            Batiment batiment = new Batiment(nombat);
            int index = Listebatiments.IndexOf(batiment);
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
            bool res = Listebatiments[index].ModifierBatiment(nvnom, pays, ville, quartier, adresse, architecte,
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
