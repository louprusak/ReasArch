using Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace Data
{
    public class Stub
    {
        public static Manager CreerManager()
        {
            Manager manager = new Manager();
            manager.AjouterVille("Clermont-Ferrand");
            manager.AjouterVille("Lyon");
            manager.AjouterVille("Paris");

            manager.AjouterBatimentSimple("Clermont-Ferrand", "Cathédrale", "France", "Clermont-Ferrand", "Description");
            manager.AjouterBatimentSimple("Clermont-Ferrand", "Cathédrale", "France", "Clermont-Ferrand", "Description");
            manager.AjouterBatimentSimple("Clermont-Ferrand", "Cathédrale", "France", "Clermont-Ferrand", "Description");
            manager.AjouterBatimentSimple("Clermont-Ferrand", "Cathédrale", "France", "Clermont-Ferrand", "Description");
            manager.AjouterBatimentSimple("Clermont-Ferrand", "Cathédrale", "France", "Clermont-Ferrand", "Description");

            manager.AjouterBatimentSimple("Lyon", "Tour Crayon", "France", "Lyon", "Description");
            manager.AjouterBatimentSimple("Lyon", "Tour Crayon", "France", "Lyon", "Description");
            manager.AjouterBatimentSimple("Lyon", "Tour Crayon", "France", "Lyon", "Description");
            manager.AjouterBatimentSimple("Lyon", "Tour Crayon", "France", "Lyon", "Description");
            manager.AjouterBatimentSimple("Lyon", "Tour Crayon", "France", "Lyon", "Description");

            manager.AjouterBatimentSimple("Paris", "Tour Effeil", "France", "Paris", "Description");
            manager.AjouterBatimentSimple("Paris", "Tour Effeil", "France", "Paris", "Description");
            manager.AjouterBatimentSimple("Paris", "Tour Effeil", "France", "Paris", "Description");
            manager.AjouterBatimentSimple("Paris", "Tour Effeil", "France", "Paris", "Description");
            manager.AjouterBatimentSimple("Paris", "Tour Effeil", "France", "Paris", "Description");

            return manager;
        }

        public static Ville CreerVille()
        {
            Ville ville = new Ville("Londres");
            ville.AjouterBatimentSimple("BigBen", "Angleterre", "Londres", "Description");
            ville.AjouterBatimentSimple("LondonEye", "Angleterre", "Londres", "Description");

            return ville;
        }

        public static Batiment CreerBatimentAvecNom()
        {
            Batiment batiment = new Batiment("Centre Jaude");
            return batiment;
        }

        public static Batiment CreerBatimentSimple()
        {
            Batiment batiment = new Batiment("Cathédrale", "France", "Clermont-Ferrand", "Ceci est la decription de la cathédrale de Clermont-Ferrand");
            return batiment;
        }

        public static Batiment CreerBatimentComplet()
        {
            Batiment batiment = new Batiment("Tour de Pise","Italie","Pise","Pise","adresse pise", "on sait pas","pas qui c'est","vieux","pierre","haut","compte pour voir","ya longtemps",
                "très longtemps","bah elle penche quoi ...");
            return batiment;
        }
    }
}
