using Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Data
{
    public class Stub
    {
        public static Ville CreerVille()
        {
            Ville ville1 = new Ville("Clermont");
            ville1.AjouterBatimentSimple("Centre jaude", "France", "Clermont-Ferrand", "Description du batiment");
            ville1.AjouterBatimentSimple("Centre jaude", "France", "Clermont-Ferrand", "Description du batiment");
            ville1.AjouterBatimentSimple("Centre jaude", "France", "Clermont-Ferrand", "Description du batiment");
            ville1.AjouterBatimentSimple("Centre jaude", "France", "Clermont-Ferrand", "Description du batiment");
            ville1.AjouterBatimentSimple("Centre jaude", "France", "Clermont-Ferrand", "Description du batiment");
            ville1.AjouterBatimentSimple("Centre jaude", "France", "Clermont-Ferrand", "Description du batiment");
            ville1.AjouterBatimentSimple("Centre jaude", "France", "Clermont-Ferrand", "Description du batiment");
            ville1.AjouterBatimentSimple("Centre jaude", "France", "Clermont-Ferrand", "Description du batiment");
            return ville1;
        }



    }
}
