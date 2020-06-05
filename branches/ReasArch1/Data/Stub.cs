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
        public static Ensemble CreerEnsemble()
        {
            Ensemble test = new Ensemble();
            test.AjouterVille("San Francisco", "img/san francisco.jpg", "img/panoramanew york.jpg");
            test.AjouterVille("New York", "img/icone_newyork.png", "img/panoramanew york.jpg");
            test.AjouterVille("Paris", "img/icone_paris.png", "img/panoramanew york.jpg");

            test.AjouterBatimentSimple("San Francisco", "Golden Gate", "USA", "San Francisco", "Description", "img/londrezs.jpg", "img/avis.png", "img/plan empire state.jpg", "img/icone_londres.png");
            test.AjouterBatimentSimple("San Francisco", "Golden Gate", "USA", "San Francisco", "Description", "img/londrezs.jpg", "img/avis.png", "img/plan empire state.jpg", "img/icone_londres.png");
            test.AjouterBatimentSimple("San Francisco", "Golden Gate", "USA", "San Francisco", "Description", "img/londrezs.jpg", "img/avis.png", "img/plan empire state.jpg", "img/icone_londres.png");
            test.AjouterBatimentSimple("San Francisco", "Golden Gate", "USA", "San Francisco", "Description", "img/londrezs.jpg", "img/avis.png", "img/plan empire state.jpg", "img/icone_londres.png");
            test.AjouterBatimentSimple("San Francisco", "Golden Gate", "USA", "San Francisco", "Description", "img/londrezs.jpg", "img/avis.png", "img/plan empire state.jpg", "img/icone_londres.png");

            test.AjouterBatimentSimple("New York", "Empire State Building", "USA", "New York", "Description", "img/londrezs.jpg", "img/avis.png", "img/plan empire state.jpg", "img/icone_londres.png");
            test.AjouterBatimentSimple("New York", "Empire State Building", "USA", "New York", "Description", "img/londrezs.jpg", "img/avis.png", "img/plan empire state.jpg", "img/icone_londres.png");
            test.AjouterBatimentSimple("New York", "Empire State Building", "USA", "New York", "Description", "img/londrezs.jpg", "img/avis.png", "img/plan empire state.jpg", "img/icone_londres.png");
            test.AjouterBatimentSimple("New York", "Empire State Building", "USA", "New York", "Description", "img/londrezs.jpg", "img/avis.png", "img/plan empire state.jpg", "img/icone_londres.png");
            test.AjouterBatimentSimple("New York", "Empire State Building", "USA", "New York", "Description", "img/londrezs.jpg", "img/avis.png", "img/plan empire state.jpg", "img/icone_londres.png");

            test.AjouterBatimentSimple("Paris", "Tour Effeil", "France", "Paris", "Description", "img/londrezs.jpg", "img/avis.png", "img/plan empire state.jpg", "img/icone_londres.png");
            test.AjouterBatimentSimple("Paris", "Tour Effeil", "France", "Paris", "Description", "img/londrezs.jpg", "img/avis.png", "img/plan empire state.jpg", "img/icone_londres.png");
            test.AjouterBatimentSimple("Paris", "Tour Effeil", "France", "Paris", "Description", "img/londrezs.jpg", "img/avis.png", "img/plan empire state.jpg", "img/icone_londres.png");
            test.AjouterBatimentSimple("Paris", "Tour Effeil", "France", "Paris", "Description", "img/londrezs.jpg", "img/avis.png", "img/plan empire state.jpg", "img/icone_londres.png");
            test.AjouterBatimentSimple("Paris", "Tour Effeil", "France", "Paris", "Description", "img/londrezs.jpg", "img/avis.png", "img/plan empire state.jpg", "img/icone_londres.png");

            return test;
        }

        public static Ville CreerVille()
        {
            Ville ville = new Ville("Londres", "img/londrezs.jpg", "img/statue_liberte.jpg");
            ville.AjouterBatimentSimple("BigBen", "Angleterre", "Londres", "Description", "img/londrezs.jpg", "img/avis.png", "img/plan empire state.jpg", "img/icone_londres.png");
            ville.AjouterBatimentSimple("LondonEye", "Angleterre", "Londres", "Description", "img/londrezs.jpg", "img/avis.png", "img/plan empire state.jpg", "img/icone_londres.png");

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
                "très longtemps","bah elle penche quoi ...","img/icone_newyork.png", "img/icone_newyork.png", "img/icone_newyork.png", "img/icone_newyork.png");
            return batiment;
        }
    }
}
