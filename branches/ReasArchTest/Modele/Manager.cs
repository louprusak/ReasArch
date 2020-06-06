using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Modele
{
    public class Manager : INotifyPropertyChanged
    {
        public Monde monde { get; set; }

        public Ville VilleSelectionnee
        {
            get => villeSelectionnee;
            set
            {
                if(villeSelectionnee != value)
                {
                    OnPropertyChanged(nameof(VilleSelectionnee));
                }
            }
        }
        private Ville villeSelectionnee;

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string PropertyName)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
    }
}
