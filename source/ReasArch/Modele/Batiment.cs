using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    public class Batiment
    {
        /// <summary>
        /// Nom du batiment
        /// </summary>
        public string Nom { get; private set; }

        /// <summary>
        /// Ville dans laquelle se trouve le batiment
        /// </summary>
        public string Ville { get; private set; }

        /// <summary>
        /// Nom de l'architecte du batiment
        /// </summary>
        public string Architecte { get; private set; }

        /// <summary>
        /// Description autre du batiment
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// Constructeur de Batiment
        /// </summary>
        /// <param name="nom">Nom du bâtiment</param>
        /// <param name="architecte">Nom de l'architecte du batiment</param>
        /// <param name="description">Description du batiment</param>
        public Batiment (string nom, string architecte, string description)
        {
            Nom = nom;
            Architecte = architecte;
            Description = description;
        }

        /// <summary>
        /// Constructeur de Batiment
        /// </summary>
        /// <param name="nom">Nom du batiment</param>
        /// <param name="ville">Nom de la ville dans laquelle se trouve le batiment</param>
        /// <param name="architecte">Nom de l'architecte du batiment</param>
        /// <param name="description">Description du batiment</param>
        public Batiment (string nom, string ville, string architecte, string description)
            : this(nom, architecte, description)
        {
            Ville = ville;
        }

        /// <summary>
        /// Méthode ToString d'un batiment qui permet de résumer les infos essentielles sur une instance de batiment
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"Nom: {Nom}\nArchitecte: {Architecte}\nDescription: {Description}";
    }
}
