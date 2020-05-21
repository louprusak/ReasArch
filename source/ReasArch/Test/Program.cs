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
            WriteLine("1) Instanciation des classes Batiment, Ville et Manager :\n\n");

            Batiment batiment1 = new Batiment("Centre Jaude");
            WriteLine(batiment1.ToString());
            WriteLine("-    -   -   -   -   -");
            Batiment batiment2 = new Batiment("Cathédrale", "France","Clermont-Ferrand", "Ceci est la decription de la cathédrale de Clermont-Ferrand");
            WriteLine(batiment2.ToString());
            WriteLine("-    -   -   -   -   -");
            Batiment batiment3 = new Batiment("Centre Jaude 2", "France", "Clermont-Ferrand", "Centre de Clermont", "Place de Jaude", "M.Jenesaispas", "M.Jenesaisqui","Comtemporain","Pierre de Volvic","50","4","2010","2012","Ceci est la description du centre Jaude 2");
            WriteLine(batiment3.ToString());
            
            Manager manager = new Manager();
            WriteLine(manager.ToString());
            manager.AjouterVille("Clermont-Ferrand");
            WriteLine(manager.ToString());
        }
    }
}
