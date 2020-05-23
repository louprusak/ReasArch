using System;
using System.ComponentModel;
using static System.Console;
using Modele;


namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("------------------------------------------------------------------------------------------------------------\n" +
                "Hello World! Voici les tests console de notre application ReasArch ! Enjoy !\n" +
                "------------------------------------------------------------------------------------------------------------\n\n");
            WriteLine("1) Instanciation de la classe Batiment:\n\n");

            Batiment batiment1 = new Batiment("Centre Jaude");
            WriteLine("ToString du Batiment avec seulement le nom:\n"+batiment1.ToString());
            WriteLine("-    -   -   -   -   -");
            Batiment batiment2 = new Batiment("Cathédrale", "France","Clermont-Ferrand", "Ceci est la decription de la cathédrale de Clermont-Ferrand");
            WriteLine("ToString du Batiment avec détail simplifié:\n"+batiment2.ToString());
            WriteLine("-    -   -   -   -   -");
            Batiment batiment3 = new Batiment("Centre Jaude 2", "France", "Clermont-Ferrand", "Centre de Clermont", "Place de Jaude", "M.Jenesaispas", "M.Jenesaisqui",
                "Comtemporain","Pierre de Volvic","50","4","2010","2012","Ceci est la description du centre Jaude 2");
            WriteLine("ToString du Batiment avec détail maximal:\n"+batiment3.ToString());

            WriteLine("------------------------------------------------------------------------------------------------------------\n");
            WriteLine("\n2) Instanciation de la classe Ville:\n\n");

            Ville ville1 = new Ville("Clermont-Ferrand");
            WriteLine("ToString de la ville juste après création:\n" + ville1.ToString());
            WriteLine("-    -   -   -   -   -");
            bool ajoutsimple = ville1.AjouterBatimentSimple("Cathédrale", "France", "Clermont - Ferrand", "Ceci est la decription de la cathédrale de Clermont - Ferrand");
            WriteLine($"Test variable ajoutsimple:{ajoutsimple}");
            WriteLine("ToString de la ville juste après ajout simple d'un batiment:\n" +ville1.ToString());
            WriteLine("-    -   -   -   -   -");
            bool ajoutcomplet = ville1.AjouterBatimentComplet("Centre Jaude 2", "France", "Clermont-Ferrand", "Centre de Clermont", "Place de Jaude", "M.Jenesaispas", "M.Jenesaisqui",
                "Comtemporain", "Pierre de Volvic", "50", "4", "2010", "2012", "Ceci est la description du centre Jaude 2");
            WriteLine($"Test variable ajoutcomplet:{ajoutcomplet}");
            WriteLine("ToString de la ville juste après ajout complet d'un batiment:\n" + ville1.ToString());
            WriteLine("-    -   -   -   -   -");
            bool supprimerbatiment = ville1.SupprimerBatiment("Cathédrale");
            WriteLine($"Test variable suppression:{supprimerbatiment}");
            WriteLine("ToString de la ville juste après suppression d'un batiment:\n" + ville1.ToString());
            WriteLine("-    -   -   -   -   -");
            bool modifierbatiment = ville1.ModifierBatiment("Centre Jaude 2", "CARRE JAUDE 2", "France", "Clermont-Ferrand", "Centre de Clermont", "Place de Jaude", "M.Jenesaispas", "M.Jenesaisqui",
                "Comtemporain", "Pierre de Volvic", "50", "4", "2010", "2012", "Ceci est la description du carre Jaude 2");
            WriteLine($"Test de la variable modification:{modifierbatiment}");
            WriteLine("ToString de la ville après modification d'un batiment:\n" + ville1.ToString());

            WriteLine("------------------------------------------------------------------------------------------------------------\n");
            WriteLine("\n3) Instanciation de la classe Manager:\n\n");

            Manager manager = new Manager();
            WriteLine("ToString de Manager juste après sa création:\n"+manager.ToString());
            WriteLine("-    -   -   -   -   -");
            bool ajoutville = manager.AjouterVille("Clermont-Ferrand");
            WriteLine($"Test de la variable d'ajout d'une ville:{ajoutville}");
            WriteLine("ToString de Manager juste après ajout d'une nouvelle ville:\n"+manager.ToString());
            WriteLine("-    -   -   -   -   -");
            bool modifierville = manager.ModifierVille("Clermont-Ferrand", "Clermont-Fd");
            WriteLine($"Test de la variable de modification d'une ville:{modifierville}");
            WriteLine("ToString de Manager juste après la modification d'une ville:\n" + manager.ToString());
            WriteLine("-    -   -   -   -   -");
            bool ajoutsimplemanager = manager.AjouterBatimentSimple("Clermont-Fd","Cathédrale", "France", "Clermont - Ferrand", "Ceci est la decription de la cathédrale de Clermont - Ferrand");
            WriteLine($"Test variable ajoutsimplemanager:{ajoutsimplemanager}");
            WriteLine("ToString de Manager juste après ajout simple d'un batiment:\n" + ville1.ToString());
            WriteLine("-    -   -   -   -   -");
            bool ajoutcompletmanager = manager.AjouterBatimentComplet("Clermont-Fd","Centre Jaude 2", "France", "Clermont-Ferrand", "Centre de Clermont", "Place de Jaude", "M.Jenesaispas", "M.Jenesaisqui",
                "Comtemporain", "Pierre de Volvic", "50", "4", "2010", "2012", "Ceci est la description du centre Jaude 2");
            WriteLine($"Test variable ajoutcompletmanager:{ajoutcompletmanager}");
            WriteLine("ToString de Manager juste après ajout complet d'un batiment:\n" + ville1.ToString());
            WriteLine("-    -   -   -   -   -");
            bool supprimerbatimentmanager = manager.SupprimerBatiment("Clermont-Fd","Cathédrale");
            WriteLine($"Test variable suppressionbatimentmanager:{supprimerbatimentmanager}");
            WriteLine("ToString de Manager juste après suppression d'un batiment:\n" + ville1.ToString());
            WriteLine("-    -   -   -   -   -");
            bool modifierbatimentmanager = manager.ModifierBatiment("Clermont-Fd","Centre Jaude 2", "CARRE JAUDE 2", "France", "Clermont-Ferrand", "Centre de Clermont", "Place de Jaude", "M.Jenesaispas", "M.Jenesaisqui",
                "Comtemporain", "Pierre de Volvic", "50", "4", "2010", "2012", "Ceci est la description du carre Jaude 2");
            WriteLine($"Test de la variable modificationbatimentmanager:{modifierbatimentmanager}");
            WriteLine("ToString de Manager après modification d'un batiment:\n" + ville1.ToString());
            bool supprimerville = manager.SupprimerVille("Clermont-Fd");
            WriteLine($"Test de la variable de suppression d'une ville:{supprimerville}");
            WriteLine("ToString de Manager juste après la suppression d'une ville:\n" + manager.ToString());
            WriteLine("-    -   -   -   -   -");

        }
    }
}
