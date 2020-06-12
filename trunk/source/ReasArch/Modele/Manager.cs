using System;
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
        public Monde monde { get; set; }

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
        private Ville villeSelectionnee;

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
        private Batiment batimentSelectionne;

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
