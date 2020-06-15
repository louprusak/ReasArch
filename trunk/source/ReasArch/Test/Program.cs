using System;
using System.ComponentModel;
using static System.Console;
using Modele;
using Data;



namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            WriteLine("------------------------------------------------------------------------------------------------------------\n" +
                "Hello World! Voici les tests console de notre application ReasArch ! Enjoy !\n" +
                "------------------------------------------------------------------------------------------------------------\n\n");
            WriteLine("1) Instanciation de la classe Batiment:\n\n");

            
            WriteLine("ToString du Batiment avec seulement le nom:\n"+Stub.CreerBatimentAvecNom().ToString());
            WriteLine("-    -   -   -   -   -");
            
            WriteLine("ToString du Batiment avec détail simplifié:\n"+Stub.CreerBatimentSimple().ToString());
            WriteLine("-    -   -   -   -   -");
            
            WriteLine("ToString du Batiment avec détail maximal:\n"+Stub.CreerBatimentComplet().ToString());




            WriteLine("------------------------------------------------------------------------------------------------------------\n");
            WriteLine("\n2) Instanciation de la classe Ville:\n\n");





            Ville villetest = Stub.CreerVille();

            WriteLine("ToString de la ville juste après création:\n" + villetest.ToString());
            WriteLine("-    -   -   -   -   -");

            bool ajoutsimple = villetest.AjouterBatimentSimple("Cathédrale", "Ceci est la decription de la cathédrale de Clermont - Ferrand","chouette.png","machin.png","bidule.png","truc.png");
            WriteLine($"Test variable ajoutsimple:{ajoutsimple}");
            WriteLine("ToString de la ville juste après ajout simple d'un batiment:\n" +villetest.ToString());
            WriteLine("-    -   -   -   -   -");

            bool ajoutcomplet = villetest.AjouterBatimentComplet("Centre Jaude 2", "Centre de Clermont", "Place de Jaude", "M.Jenesaispas", "M.Jenesaisqui",
                "Comtemporain", "Pierre de Volvic", "50", "4", "2010", "2012", "Ceci est la description du centre Jaude 2","chouette.png", "machin.png", "bidule.png", "truc.png");
            WriteLine($"Test variable ajoutcomplet:{ajoutcomplet}");
            WriteLine("ToString de la ville juste après ajout complet d'un batiment:\n" + villetest.ToString());
            WriteLine("-    -   -   -   -   -");

            bool supprimerbatiment = villetest.Listebatiments.Remove(new Batiment("Cathédrale"));
            WriteLine($"Test variable suppression:{supprimerbatiment}");
            WriteLine("ToString de la ville juste après suppression d'un batiment:\n" + villetest.ToString());
            WriteLine("-    -   -   -   -   -");

          





            WriteLine("------------------------------------------------------------------------------------------------------------\n");
            WriteLine("\n3) Instanciation de la classe Monde:\n\n");






            Monde manager = Stub.CreerEnsemble();
            WriteLine("ToString de Monde juste après sa création:\n"+manager.ToString());
            WriteLine("-    -   -   -   -   -");

            bool ajoutville = manager.AjouterVille("Clermont-Ferrand","France","img/icone_londre.png","");
            WriteLine($"Test de la variable d'ajout d'une ville:{ajoutville}");
            WriteLine("ToString de Monde juste après ajout d'une nouvelle ville:\n"+manager.ToString());
            WriteLine("-    -   -   -   -   -");

            bool ajoutsimplemanager = manager.AjouterBatimentSimple("Clermont-Ferrand","Cathédrale","Ceci est la decription de la cathédrale de Clermont - Ferrand","","","","");
            WriteLine($"Test variable ajoutsimplemanager:{ajoutsimplemanager}");
            WriteLine("ToString de Monde juste après ajout simple d'un batiment:\n" + manager.ToString());
            WriteLine("-    -   -   -   -   -");

            bool ajoutcompletmanager = manager.AjouterBatimentComplet("Clermont-Ferrand", "Clermont-Ferrand", "Centre de Clermont", "Place de Jaude", "M.Jenesaispas", "M.Jenesaisqui",
                "Comtemporain", "Pierre de Volvic", "50", "4", "2010", "2012", "Ceci est la description du centre Jaude 2","","","","");
            WriteLine($"Test variable ajoutcompletmanager:{ajoutcompletmanager}");
            WriteLine("ToString de Monde juste après ajout complet d'un batiment:\n" + manager.ToString());
            WriteLine("-    -   -   -   -   -");

            bool supprimerbatimentmanager = manager.SupprimerBatiment("Clermont-Ferrand","Cathédrale");
            WriteLine($"Test variable suppressionbatimentmanager:{supprimerbatimentmanager}");
            WriteLine("ToString de Monde juste après suppression d'un batiment:\n" + manager.ToString());
            WriteLine("-    -   -   -   -   -");

            bool supprimerville = manager.SupprimerVille("Clermont-Ferrand");
            WriteLine($"Test de la variable de suppression d'une ville:{supprimerville}");
            WriteLine("ToString de Monde juste après la suppression d'une ville:\n" + manager.ToString());
            WriteLine("-    -   -   -   -   -");

            */


           /* WriteLine("------------------------------------------------------------------------------------------------------------\n");
            WriteLine("\n4) Instanciation de la classe Manager:\n\n");



            Manager testmanager = Stub.CreerManager();
            Ville ville = new Ville("VilleTest");
            Ville villemodif = new Ville("VilleModif");
            Batiment batiment = new Batiment("BatimentTest");
            Batiment batimentmodif = new Batiment("BatimentModif");
            testmanager.VilleSelectionnee = villemodif;

            bool mngajoutville = testmanager.AjouterVille(ville);
            WriteLine($"Test de la variable d'ajout d'une ville au monde du manager:{mngajoutville}");
            WriteLine("ToString de Monde juste après:\n" + testmanager.Monde.ToString());
            WriteLine("-    -   -   -   -   -");

            testmanager.ModifierVille(ville, villemodif);
            WriteLine("ToString de Monde juste après modification du batiment:\n" + testmanager.Monde.ToString());
            WriteLine("-    -   -   -   -   -");

            bool mngajoutbat = testmanager.AjouterBatiment(batiment);
            WriteLine($"Test de la variable d'ajout d'un batiment au monde du manager:{mngajoutbat}");
            WriteLine("ToString de Monde juste après:\n" + testmanager.Monde.ToString());
            WriteLine("-    -   -   -   -   -");

            testmanager.ModifierBatiment(batiment, batimentmodif);
            WriteLine("ToString de Monde juste après modification du batiment:\n" + testmanager.Monde.ToString());
            WriteLine("-    -   -   -   -   -");

            bool mngsupprbat = testmanager.SupprimerBatiment(batimentmodif);
            WriteLine($"Test de la variable de suppression d'un batiment au monde du manager:{mngsupprbat}");
            WriteLine("ToString de Monde juste après:\n" + testmanager.Monde.ToString());
            WriteLine("-    -   -   -   -   -");

            bool mngsupprville = testmanager.SupprimerVille(villemodif);
            WriteLine($"Test de la variable de suppression d'une ville au monde du manager:{mngsupprville}");
            WriteLine("ToString de Monde juste après:\n" + testmanager.Monde.ToString());
            WriteLine("-    -   -   -   -   -");*/


        }
    }
}
