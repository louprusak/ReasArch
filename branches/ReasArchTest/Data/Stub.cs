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
        public static Monde CreerEnsemble()
        {
            Monde test = new Monde();
            test.AjouterVille("San Francisco", "vignette_sanfrancisco.jpg", "panorama_sanfrancisco.jpg");
            test.AjouterVille("New York", "statue_liberte.jpg", "panorama_newyork.jpg");
            test.AjouterVille("Paris", "vignette_paris.jpg", "panorama_paris.jpg");
            test.AjouterVille("Londres", "vignette_londres.jpg", "panorama_londres.jpg");

            test.AjouterBatimentSimple("San Francisco", "Golden Gate", "USA", "San Francisco", "Description", "londrezs.jpg", "avis.png", "plan empire state.jpg", "icone_londres.png");
            test.AjouterBatimentSimple("San Francisco", "Golden Gate", "USA", "San Francisco", "Description", "londrezs.jpg", "avis.png", "plan empire state.jpg", "icone_londres.png");
            test.AjouterBatimentSimple("San Francisco", "Golden Gate", "USA", "San Francisco", "Description", "londrezs.jpg", "avis.png", "plan empire state.jpg", "icone_londres.png");
            test.AjouterBatimentSimple("San Francisco", "Golden Gate", "USA", "San Francisco", "Description", "londrezs.jpg", "avis.png", "plan empire state.jpg", "icone_londres.png");
            test.AjouterBatimentSimple("San Francisco", "Golden Gate", "USA", "San Francisco", "Description", "londrezs.jpg", "avis.png", "plan empire state.jpg", "icone_londres.png");

            test.AjouterBatimentSimple("New York", "Empire State Building", "USA", "New York", "Description", "londrezs.jpg", "avis.png", "plan empire state.jpg", "icone_londres.png");
            test.AjouterBatimentSimple("New York", "Empire State Building", "USA", "New York", "Description", "londrezs.jpg", "avis.png", "plan empire state.jpg", "icone_londres.png");
            test.AjouterBatimentSimple("New York", "Empire State Building", "USA", "New York", "Description", "londrezs.jpg", "avis.png", "plan empire state.jpg", "icone_londres.png");
            test.AjouterBatimentSimple("New York", "Empire State Building", "USA", "New York", "Description", "londrezs.jpg", "avis.png", "plan empire state.jpg", "icone_londres.png");
            test.AjouterBatimentSimple("New York", "Empire State Building", "USA", "New York", "Description", "londrezs.jpg", "avis.png", "plan empire state.jpg", "icone_londres.png");

            test.AjouterBatimentSimple("Paris", "Tour", "France", "Paris", "Description", "londrezs.jpg", "avis.png", "plan empire state.jpg", "icone_londres.png");
            test.AjouterBatimentSimple("Paris", "Tour", "France", "Paris", "Description", "londrezs.jpg", "avis.png", "plan empire state.jpg", "icone_londres.png");
            test.AjouterBatimentSimple("Paris", "Tour", "France", "Paris", "Description", "londrezs.jpg", "avis.png", "plan empire state.jpg", "icone_londres.png");
            test.AjouterBatimentSimple("Paris", "Tour", "France", "Paris", "Description", "londrezs.jpg", "avis.png", "plan empire state.jpg", "icone_londres.png");
            test.AjouterBatimentSimple("Paris", "Tour", "France", "Paris", "Description", "londrezs.jpg", "avis.png", "plan empire state.jpg", "icone_londres.png");

            return test;
        }

        public static Ville CreerVille()
        {
            Ville ville = new Ville("Londres", "londrezs.jpg", "statue_liberte.jpg");
            ville.AjouterBatimentSimple("BigBen", "Angleterre", "Londres", "Description", "londrezs.jpg", "avis.png", "plan empire state.jpg", "icone_londres.png");
            ville.AjouterBatimentSimple("LondonEye", "Angleterre", "Londres", "Description", "londrezs.jpg", "avis.png", "plan empire state.jpg", "icone_londres.png");

            return ville;
        }

        public static Batiment CreerBatimentAvecNom()
        {
            Batiment batiment = new Batiment("Centre Jaude");
            return batiment;
        }

        public static Batiment CreerBatimentSimple()
        {
            Batiment batiment = new Batiment("Cathédrale", "France", "Clermont-Ferrand", "Ceci est la decription de la cathédrale de Clermont-Ferrand","","","","");
            return batiment;
        }

        public static Batiment CreerBatimentComplet()
        {
            Batiment batiment = new Batiment("Tour de Pise","Italie","Pise","Pise","adresse pise", "on sait pas","pas qui c'est","vieux","pierre","haut","compte pour voir","ya longtemps",
                "très longtemps","bah elle penche quoi ...","icone_newyork.png", "icone_newyork.png", "icone_newyork.png", "icone_newyork.png");
            return batiment;
        }
    }
}
