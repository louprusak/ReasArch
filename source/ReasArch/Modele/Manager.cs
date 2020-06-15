using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Modele
{
    /// <summary>
    /// Classe Manager de l'application: c'est la seul classe qui sera en lien avec les fenêtres XAML et c'est également la seul qui gérera les données de l'application
    /// </summary>
    public class Manager : INotifyPropertyChanged
    {
        /// <summary>
        /// Propriété Monde du manager qui regroupe toutes les villes et les batiments de l'application
        /// </summary>
        public Monde Monde
        {
            get { return monde; }
            set { monde = value; }
        }
        private Monde monde;


        /// <summary>
        /// Propriété Ville Sélectionnée de manager qui permet de faire le lien avec le data binding et les usercontrols du XAML
        /// </summary>
        public Ville VilleSelectionnee
        {
            get => villeSelectionnee;
            set
            {
                if(villeSelectionnee != value)
                {
                    villeSelectionnee = value;
                    OnPropertyChanged(nameof(VilleSelectionnee));
                }
            }
        }
        private Ville villeSelectionnee; 


        /// <summary>
        /// Propriété Batiment Sélectionné de manager qui permet de faire le lien avec le data binding et les usercontrols du XAML
        /// </summary>
        public Batiment BatimentSelectionne
        {
            get => batimentSelectionne;
            set
            {
                if (batimentSelectionne != value)
                {
                    batimentSelectionne = value;
                    OnPropertyChanged(nameof(VilleSelectionnee));
                }
            }
        }
        private Batiment batimentSelectionne;


        public IPersistanceManager Persistance { get; set; }


        public void ChargeDonnées()
        {
            Monde LeMonde = Persistance.ChargeDonnées();
            monde = new Monde();
            foreach (var v in LeMonde.Listevilles)
            {
                monde.Listevilles.Add(v);
            }
        }


        public void SauvegardeDonnées()
        {
            Persistance.SauvegardeDonnées(monde);
        }

        public Manager()
        {
            Monde monde = new Monde();
        }

        public Manager(IPersistanceManager persistance)
        {
            Persistance = persistance;
            Monde monde = new Monde();
        }


        //------------------------------------------------------------------------------------//
        //METHODES


        /// <summary>
        /// Permet d'ajouter une ville à la collection de ville en passant comme paramètre l'objet de type Modele.Ville que l'on veut ajouter
        /// </summary>
        /// <param name="ville">Objet de type Modele.Ville à ajouter à la liste</param>
        /// <returns> Retourne true si la ville a bien été ajoutée à la liste sinon retourne false</returns>
        public bool AjouterVille(Modele.Ville ville)
        {
            bool res = monde.AjouterVille(ville.Nom, ville.Pays, ville.Imagevignette, ville.Imagepanorama);
            return res;
        }

        /// <summary>
        /// Permet de supprimer une ville de la collection de ville en passant comme paramètre l'objet de type Modele.Ville que l'on veut supprimer
        /// </summary>
        /// <param name="ville">Objet de type Modele.Ville à supprimer de la liste</param>
        /// <returns> Retourne true si la ville a bien été supprimée de la liste sinon retourne false</returns>
        public bool SupprimerVille(Modele.Ville ville)
        {
            bool res = monde.SupprimerVille(ville.Nom);
            return res;
        }

        /// <summary>
        /// Permet de modifier une ville dans la collection en passant comme paramètre la ville sans les modifications et la ville avec les modifications
        /// </summary>
        /// <param name="oldville">Ancienne ville affichée sans les modifications</param>
        /// <param name="newville">Nouvelle ville qui sera affichée avec les modidications</param>
        public void ModifierVille(Modele.Ville oldville, Modele.Ville newville)
        {
            Type typeville = typeof(Modele.Ville);
            var villeproperties = typeville.GetProperties();
            foreach (var property in villeproperties.Where(ppty => ppty.CanWrite))
            {
                property.SetValue(oldville, property.GetValue(newville));
            }
        }

        /// <summary>
        /// Permet d'ajouter un batiment avec description complète à la liste des batiments dans la ville sélectionnée de l'application
        /// </summary>
        /// <param name="b">Objet de type Modele.Batiment à ajouter à la liste</param>
        /// <returns> Retourne true si le batiment à bien été ajouté à la liste de batiments de la ville sinon retourne false</returns>
        public bool AjouterBatiment(Modele.Batiment b)
        {
            bool res = monde.AjouterBatimentComplet(VilleSelectionnee.Nom,b.Nom, b.Quartier, b.Adresse, b.Architecte, b.Ingenieur, b.Style, b.Materiaux,
                b.Hauteur, b.Nbetages, b.Construction, b.Ouverture, b.Description, b.Imageprincipale, b.Imagearchitecte, b.Imageplan, b.Imageinterieur);
            return res;
        }

        /// <summary>
        /// Permet de supprimer un batiment de la liste de batiments de la ville sélectionnée de l'application
        /// </summary>
        /// <param name="batiment">Objet de type Modele.Batiment à supprimer de la liste</param>
        /// <returns>Retourne true si le batiment à bien été supprimé de la liste sinon retourne false</returns>
        public bool SupprimerBatiment(Modele.Batiment batiment)
        {
            bool res = monde.SupprimerBatiment(villeSelectionnee.Nom, batiment.Nom);
            return res;
        }

        /// <summary>
        /// Permet de modifier un batiment donné dans la collection d'une ville donnée
        /// </summary>
        /// <param name="oldbatiment">Ancien Batiment affiché sans les modifications</param>
        /// <param name="newbatiment">Nouveau Batiment qui sera affiché avec les modifications</param>
        public void ModifierBatiment(Modele.Batiment oldbatiment, Modele.Batiment newbatiment)
        {
            Type typebatiment = typeof(Modele.Batiment);
            var batimentproperties = typebatiment.GetProperties();
            foreach(var property in batimentproperties.Where(ppty => ppty.CanWrite))
            {
                property.SetValue(oldbatiment, property.GetValue(newbatiment));
            }
        }


        //------------------------------------------------------------------------------------//
        //REDEFINITION DE METHODES


        /// <summary>
        /// Event de changement de propriété des objects
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Méthode appelée lors du changement de propriété des objects afin de refaire remonter l'information et ainsi de modifier le visuel XAML
        /// </summary>
        void OnPropertyChanged(string PropertyName)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
    }
}
