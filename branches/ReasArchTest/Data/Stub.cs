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
            test.AjouterVille("San Francisco", "SanFrancisco/vignette.jpg", "SanFrancisco/panorama.jpg");
            test.AjouterVille("New York", "NewYork/vignette.jpg", "NewYork/panorama.jpg");
            test.AjouterVille("Paris", "Paris/vignette.jpg", "Paris/panorama.jpg");
            test.AjouterVille("Londres", "Londres/vignette.jpg", "Londres/panorama.jpg");

            test.AjouterBatimentSimple("San Francisco", "Golden Gate", "USA", "San Francisco", "Description", "GoldenGate/golden_gate.jpg", "GoldenGate/architecte.jpg", "GoldenGate/plan.jpg", "GoldenGate/interieur.jpg");
            test.AjouterBatimentSimple("San Francisco", "Coit Tower", "USA", "San Francisco", "Description", "CoitTower/coit_tower.jpg", "CoitTower/architecte.jpg", "CoitTower/plan.gif", "CoitTower/interieur.jpg");
            test.AjouterBatimentSimple("San Francisco", "Transamerica Pyramid", "USA", "San Francisco", "Description", "TransamericaPyramid/transamerica_pyramid.jpg","TransamericaPyramid/architecte.jpg", "TransamericaPyramid/plan.png", "TransamericaPyramid/interieur.png");
            test.AjouterBatimentSimple("San Francisco", "Ferry Building", "USA", "San Francisco", "Description", "FerryBuilding/ferry_building.jpg", "no_image_available.png", "FerryBuilding/plan.jpg", "FerryBuilding/interieur.jpg");
            

            test.AjouterBatimentSimple("New York", "Empire State Building", "USA", "New York", "Description", "EmpireStateBuilding/empire_state_building.jpg", "EmpireStateBuilding/architecte.png", "EmpireStateBuilding/plan.jpg", "EmpireStateBuilding/interieur.jpg");
            test.AjouterBatimentSimple("New York", "Chrysler Building", "USA", "New York", "Description", "ChryslerBuilding/chrysler_building.jpg", "ChryslerBuilding/architecte.jpg", "ChryslerBuilding/plan.jpg", "ChryslerBuilding/interieur.jpg");
            test.AjouterBatimentSimple("New York", "One World Trade Center", "USA", "New York", "Description", "OneWorldTradeCenter/one_world_trade_center.jpg", "OneWorldTradeCenter/architecte.jpg", "OneWorldTradeCenter/plan.jpg", "OneWorldTradeCenter/interieur.jpg");
            test.AjouterBatimentSimple("New York", "Flatiron Building", "USA", "New York", "Description", "FlatIronBuilding/flatiron building.jpg", "FlatIronBuilding/architecte.jpg", "FlatIronBuilding/plan.jpg", "FlatIronBuilding/interieur.jpg");
            test.AjouterBatimentSimple("New York", "Metropolitan Museum Of Art", "USA", "New York", "Description", "MMOA/mmoa.jpg", "MMOA/architecte.jpg", "MMOA/plan.jpg", "MMOA/interieur.jpg");

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
