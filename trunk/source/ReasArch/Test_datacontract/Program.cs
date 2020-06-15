using System;
using Modele;
using Data;

namespace Test_datacontract
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager(new Data.Stub());
            manager.ChargeDonnées();
            manager.Persistance = new DataContractPersistance.DataContractPers();
            Console.WriteLine(manager.Monde.ToString());
            manager.SauvegardeDonnées();
        }
    }
}
