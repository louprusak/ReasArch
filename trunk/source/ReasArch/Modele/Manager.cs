﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Modele
{
    public class Manager : INotifyPropertyChanged
    {
        /// <summary>
        /// Attribut Monde du manager qui regroupe toutes les villes et les batiments de l'application
        /// </summary>
        public Monde MONDE
        {
            get { return monde; }
            set { monde = value; }
        }
        private Monde monde;


        /// <summary>
        /// Attribut Ville Sélectionnée de manager ce qui permet de faire le lien avec le data binding et les usercontrols
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
        private Ville villeSelectionnee; // initialistaion de la variable contenant la ville sélectionnée


        /// <summary>
        /// Attribut Batiment Sélectionné de manager ce qui permet de faire le lien avec le data binding et les usercontrols
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
        private Batiment batimentSelectionne;  // initialistaion de la variable contenant le bâtiment sélectionné


        /// <summary>
        /// Permet d'ajouter une ville à la collection de ville
        /// </summary>
        /// <returns> Retourne true si la liste a bien été ajoutée à la liste sinon retourne false</returns>
        public bool AjouterVille(Modele.Ville ville)
        {
            bool res = monde.AjouterVille(ville.NOM, ville.PAYS, ville.IMAGEVIGNETTE, ville.IMAGEPANORAMA);
            return res;
        }


        /// <summary>
        /// Permet de supprimer une ville de la collection de ville
        /// </summary>
        /// <returns> Retourne true si la liste a bien été supprimée à la liste sinon retourne false</returns>
        public bool SupprimerVille(Modele.Ville ville)
        {
            bool res = monde.SupprimerVille(ville.NOM);
            return res;
        }


        /// <summary>
        /// Permet d'ajouter un batiment complet à la liste des batiments dans une ville sélectionnée
        /// </summary>
        /// <returns> Retourne true si le batiment à bien été ajouté </returns>
        public bool AjouterBatiment(Modele.Batiment b)
        {
            bool res = monde.AjouterBatimentComplet(VilleSelectionnee.NOM,b.NOM, b.PAYS, b.VILLE, b.QUARTIER, b.ADRESSE, b.ARCHITECTE, b.INGENIEUR, b.STYLE, b.MATERIAUX,
                b.HAUTEUR, b.NBETAGES, b.CONSTRUCTION, b.OUVERTURE, b.DESCRIPTION, b.IMAGEPRINCIPALE, b.IMAGEARCHITECTE, b.IMAGEPLAN, b.IMAGEINTERIEUR);
            return res;
        }


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
