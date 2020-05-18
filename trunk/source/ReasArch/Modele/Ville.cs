using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    public class Ville
    {  
        public string Nom { get; set; }
        public List<Batiment> Listebatiments { get; private set; }

        //-----------------------------------------------------------------------------------------------------------//
        //CONSTRUCTEURS

        /// <summary>
        /// Constructeur de la class Ville
        /// </summary>
        /// <param name="nom">Nom de la ville</param>
        public Ville (string nom)
        {
            if(!String.IsNullOrEmpty(nom) | !String.IsNullOrWhiteSpace(nom))
            {
                Nom = nom;
                Listebatiments = new List<Batiment>();
            }
            
        }

        //-----------------------------------------------------------------------------------------------------------//
        //METHODES

        /// <summary>
        /// Ajouter un batiment avec un détail simple à cette ville
        /// </summary>
        /// <returns>Retourne true si le batiment a bien été ajouté à la liste</returns>
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
        /// <returns>Retourne true si le batiment a bien été ajouté à la liste</returns>
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
        /// <returns>Retourne true si le batiment n'est plus présent dans la liste</returns>
        public bool SupprimerBatiment(string nom)
        {
            Batiment batiment = new Batiment(nom);
            Listebatiments.Remove(batiment);
            if (Listebatiments.Contains(batiment)){ return false; }
            else return true;
        }

        public int RechercherBatiment(string nombat)
        {
            Batiment batiment = new Batiment(nombat);
            int index = Listebatiments.IndexOf(batiment);
            return index;
        }

        /// <summary>
        /// Modifier un batiment présent dans la liste
        /// </summary>
        /// <returns></returns>
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

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (this == obj) return true;
            if (this.GetType() != obj.GetType()) return false;
            Ville other = (Ville)obj;
            return Nom.Equals(other.Nom);
        }




    }
}
