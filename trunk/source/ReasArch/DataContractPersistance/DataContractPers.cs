using Modele;
using System;
using System.IO;
using System.Runtime.Serialization;

namespace DataContractPersistance
{
    public class DataContractPers : IPersistanceManager
    {
        public string FilePath { get; set; } = Path.Combine(Directory.GetCurrentDirectory(), "..//XML");

        public string FileName { get; set; } = "ReasArch.xml";

        private DataContractSerializer Serializer { get; set; } = new DataContractSerializer(typeof(Monde),
            new DataContractSerializerSettings() { PreserveObjectReferences = true });

        public Monde ChargeDonnées()
        {
            if (!Directory.Exists(FilePath))
            {
                throw new FileNotFoundException("Fichier introuvable");
            }
            Monde LeMonde;
            using (Stream s = File.OpenRead(Path.Combine(FilePath, FileName)))
            {
                LeMonde = Serializer.ReadObject(s) as Monde;
            }
            return LeMonde;
        }

        public void SauvegardeDonnées(Monde LeMonde)
        {
            var serializer = new DataContractSerializer(typeof(Monde));
            if (!Directory.Exists(FilePath))
            {
                Directory.CreateDirectory(FilePath);
            }
            using (Stream s = File.Create(Path.Combine(FilePath, FileName)))
            {
                serializer.WriteObject(s, LeMonde);
            }
        }
    }
}
