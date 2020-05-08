using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    public class Ville
    {
        public string Nom { get; private set; }

        public List<Batiment> Listebatiments { get; private set; }

        public Ville (string nom)
        {
            Nom = nom;
            Listebatiments = new List<Batiment>();
        }
        
        public bool AjouterBatiment ( string nom, string architecte, string description)
        {
            Batiment batiment = new Batiment(nom, architecte, description);
            Listebatiments.Add(batiment);
            return true;
        }


    }
}
