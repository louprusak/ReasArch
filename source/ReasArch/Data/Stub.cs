using Modele;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace Data
{
    public class Stub: IPersistanceManager
    {

        public Monde ChargeDonnées()
        {
            Monde LeMonde = CreerEnsemble();
            return LeMonde;
        }

        public void SauvegardeDonnées(Monde LeMonde)
        {
            Debug.WriteLine("Sauvegarde demandée");
        }

        public static Monde CreerEnsemble()
        {
            Monde test = new Monde();
            test.AjouterVille("San Francisco","Etats Unis d'Amérique", "SanFrancisco/vignette.jpg", "SanFrancisco/panorama.jpg");
            test.AjouterVille("New York", "Etats Unis d'Amérique", "NewYork/vignette.jpg", "NewYork/panorama.jpg");
            test.AjouterVille("Paris", "France", "Paris/vignette.jpg", "Paris/panorama.jpg");
            test.AjouterVille("Londres", "Royaume Uni", "Londres/vignette.jpg", "Londres/panorama.jpg");

            test.AjouterBatimentSimple("San Francisco", "Golden Gate", "Description", "GoldenGate/golden_gate.jpg", "GoldenGate/architecte.jpg", "GoldenGate/plan.jpg", "GoldenGate/interieur.jpg");
            test.AjouterBatimentSimple("San Francisco", "Coit Tower", "Description", "CoitTower/coit_tower.jpg", "CoitTower/architecte.jpg", "CoitTower/plan.gif", "CoitTower/interieur.jpg");
            test.AjouterBatimentSimple("San Francisco", "Transamerica Pyramid", "Description", "TransamericaPyramid/transamerica_pyramid.jpg","TransamericaPyramid/architecte.jpg", "TransamericaPyramid/plan.png", "TransamericaPyramid/interieur.png");
            test.AjouterBatimentSimple("San Francisco", "Ferry Building", "Description", "FerryBuilding/ferry_building.jpg", "no_image_available.png", "FerryBuilding/plan.jpg", "FerryBuilding/interieur.jpg");
            
            test.AjouterBatimentSimple("New York", "Empire State Building", "Description", "EmpireStateBuilding/empire_state_building.jpg", "EmpireStateBuilding/architecte.png", "EmpireStateBuilding/plan.jpg", "EmpireStateBuilding/interieur.jpg");
            test.AjouterBatimentSimple("New York", "Chrysler Building", "Description", "ChryslerBuilding/chrysler_building.jpg", "ChryslerBuilding/architecte.jpg", "ChryslerBuilding/plan.jpg", "ChryslerBuilding/interieur.jpg");
            test.AjouterBatimentSimple("New York", "One World Trade Center","Description", "OneWorldTradeCenter/one_world_trade_center.jpg", "OneWorldTradeCenter/architecte.jpg", "OneWorldTradeCenter/plan.jpg", "OneWorldTradeCenter/interieur.jpg");
            test.AjouterBatimentSimple("New York", "Flatiron Building", "Description", "FlatIronBuilding/flatiron building.jpg", "FlatIronBuilding/architecte.jpg", "FlatIronBuilding/plan.jpg", "FlatIronBuilding/interieur.jpg");
            test.AjouterBatimentSimple("New York", "Metropolitan Museum Of Art", "Description", "MMOA/mmoa.jpg", "MMOA/architecte.jpg", "MMOA/plan.jpg", "MMOA/interieur.jpg");

            test.AjouterBatimentSimple("Paris", "Tour Eiffel", "Description", "TourEiffel/toureiffel.webp", "TourEiffel/archtoureiffel.jpg", "TourEiffel/plantoureiffel.jpg", "TourEiffel/intertoureiffel.jpg");
            test.AjouterBatimentSimple("Paris", "Arc de triomphe", "Description", "ArcDeTriomphe/arcdetriomphe.jpg", "ArcDeTriomphe/archarcdetriomphe.jpg", "ArcDeTriomphe/planarcdetriomphe.jpg", "ArcDeTriomphe/interarcdetriomphe.jpg");
            test.AjouterBatimentSimple("Paris", "Pyramide du Louvre", "Description", "PyramideDuLouvre/pyramidedulouvre.jpg", "PyramideDuLouvre/archpyramidedulouvre.jpg", "PyramideDuLouvre/planpyramidedulouvre.jfif", "PyramideDuLouvre/interpyramidedulouvre.jfif");
            test.AjouterBatimentSimple("Paris", "Notre-Dame de Paris", "Description", "NotreDameDeParis/notredamedeparis.jpg", "NotreDameDeParis/archnotredamedeparis.jpg", "NotreDameDeParis/plannotredamedeparis.jpg", "NotreDameDeParis/internotredamedeparis.jpg");
            test.AjouterBatimentSimple("Paris", "Obélisque de Louxor", "Description", "ObelisqueDeLouxor/obelisquedelouxor.jpg", "ObelisqueDeLouxor/archobelisquedelouxor.jpg", "ObelisqueDeLouxor/planobelisquedelouxor.jpg", "ObelisqueDeLouxor/interobelisquedelouxor.jpg");
            test.AjouterBatimentSimple("Paris", "Grande Arche de la Défense", "Description", "GrandeArcheDeLaDefense/grandearchdeladefense.jpg", "GrandeArcheDeLaDefense/archgrandearchdeladefense.jpg", "GrandeArcheDeLaDefense/plangrandearchdeladefense.jpg", "GrandeArcheDeLaDefense/intergrandearchdeladefense.jpg");

            test.AjouterBatimentSimple("Londres", "Big Ben",  "Description", "BigBen/bigben.jpeg", "BigBen/archbigben.jpg", "BigBen/planbigben.jpg", "BigBen/interbigben.jpg");
            test.AjouterBatimentSimple("Londres", "Palais de Westminster",  "Description", "PalaisDeWestminster/palaisdewestminster.jpg", "PalaisDeWestminster/archpalaisdewestminster.jpg", "PalaisDeWestminster/planpalaisdewestminster.jpg", "PalaisDeWestminster/interpalaisdewestminster.jpg");
            test.AjouterBatimentSimple("Londres", "London Eye",  "Description", "LondonEye/londoneye.jpg", "LondonEye/archlondoneye.jpg", "LondonEye/planlondoneye.jpg", "LondonEye/interlondoneye.jpg");
            test.AjouterBatimentSimple("Londres", "L'Ogive de Foster",  "Description", "LOgiveDeFoster/logivedefoster.jpg", "LOgiveDeFoster/archlogivedefoster.jpg", "LOgiveDeFoster/planlogivedefoster.jfif", "LOgiveDeFoster/interlogivedefoster.jpg");

            return test;
        }

        public static Manager CreerManager()
        {
            Manager manager = new Manager();
            manager.Monde = CreerEnsemble();
            return manager;
        }

        /*
        public static Ville CreerVille()
        {
            Ville ville = new Ville("Londres", "Angleterre", "no_image_available.png", "no_image_available.png");
            ville.AjouterBatimentSimple("BigBen", "Description bigben", "no_image_available.png", "no_image_available.png", "no_image_available.png", "no_image_available.png");
            ville.AjouterBatimentSimple("LondonEye", "Description london eye", "no_image_available.png", "no_image_available.png", "img/plan empire state.jpg", "img/icone_londres.png");

            return ville;
        }

        public static Batiment CreerBatimentAvecNom()
        {
            Batiment batiment = new Batiment("Centre Jaude");
            return batiment;
        }

        public static Batiment CreerBatimentSimple()
        {
            Batiment batiment = new Batiment("Cathédrale", "France", "Clermont-Ferrand", "Ceci est la decription de la cathédrale de Clermont-Ferrand", "", "", "", "");
            return batiment;
        }

        public static Batiment CreerBatimentComplet()
        {
            Batiment batiment = new Batiment("Tour de Pise", "Italie", "Pise", "Pise", "adresse pise", "on sait pas", "pas qui c'est", "vieux", "pierre", "haut", "compte pour voir", "ya longtemps",
                "très longtemps", "bah elle penche quoi ...", "img/icone_newyork.png", "img/icone_newyork.png", "img/icone_newyork.png", "img/icone_newyork.png");
            return batiment;
        }
        */
    }
}
