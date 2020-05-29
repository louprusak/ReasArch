using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    public class Ville
    {  
        public string Nom { get; set; } // nom de la ville 
        public string Imagevignette { get; set; }// Image de la vignette de la ville
        public List<Batiment> Listebatiments { get; private set; } // liste des batiments contenuent dans la ville

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
                Listebatiments = new List<Batiment>();
            }
        }

        /// <summary>
        /// Constructeur de la class Ville avec l'image
        /// </summary>
        public Ville (string nom, string imagevignette)
        {
            if(!String.IsNullOrEmpty(nom) | !String.IsNullOrWhiteSpace(nom))
            {
                Nom = nom;
                Imagevignette = imagevignette;
                Listebatiments = new List<Batiment>();
            }
         }

        //-----------------------------------------------------------------------------------------------------------//
        //METHODES

        /// <summary>
        /// Ajouter un batiment avec un détail simple à cette ville
        /// </summary>
        /// <returns>Retourne true si le batiment a bien été ajouté à la liste sinon retourne false</returns>
        public bool AjouterBatimentSimple(string nom, string pays, string ville, string description)
        {
            Batiment batiment = new Batiment(nom, pays, ville, description);
            Listebatiments.Add(batiment);
            if(Listebatiments.Contains(batiment)) { return true; }
            else { return false; }
        }

        /// <summary>
        /// Ajouter un batiment avec un détail complet à cette ville
        /// </summary>
        /// <returns>Retourne true si le batiment a bien été ajouté à la liste sinon retourne false</returns>
        public bool AjouterBatimentComplet(string nom, string pays, string ville, string quartier, string adresse,
            string architecte, string ingenieur, string style, string materiaux, string hauteur, string nbetages,
            string construction, string ouverture, string description)
        {
            Batiment batiment = new Batiment(nom, pays, ville, quartier, adresse, architecte, ingenieur, style, materiaux,
                hauteur, nbetages, construction, ouverture, description);
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
            string nbetages, string construction, string ouverture, string description)
        {
            int index = RechercherBatiment(nombat);
            bool res = Listebatiments[index].ModifierBatiment(nvnom, pays, ville, quartier, adresse, architecte,
                ingenieur,style, materiaux, hauteur, nbetages, construction, ouverture, description);
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

        public override string ToString()
        {
            string message = $"Description de la ville {Nom.ToUpper()} et de ses batiments :\n\n";
            foreach(Batiment batiment in Listebatiments)
            {
                message += batiment.ToString();
            }
            return message;
        }




    }
}
