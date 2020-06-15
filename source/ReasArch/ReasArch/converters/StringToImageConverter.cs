using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Data;

namespace ReasArch.converters
{
    /// <summary>
    /// Convertisseur de chemin d'images en images nécessaires pour le bon fonctionnement du visuel de l'application
    /// </summary>
    class StringToImageConverter : IValueConverter
    {
        /// <summary>
        /// chemin du dossier dans lequel les images sont stockées
        /// </summary>
        public static string imagesPath;

        /// <summary>
        /// Constructeur de la classe, on récupère le dossier actuel et on précise ou on veut enregistrer les images
        /// </summary>
        static StringToImageConverter()
        {
            imagesPath = Path.Combine(Directory.GetCurrentDirectory(), "..\\images\\");
        }

        /// <summary>
        /// Permet de convertir le chemin d'une image en fichier image pour l'affichage
        /// </summary>
        /// <returns>Retourne l'uri dans le dossier de stockage d'une image en question</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string imageName = value as string;
            if (string.IsNullOrWhiteSpace(imageName)) return null;
            string imagePath = Path.Combine(imagesPath, imageName);
            return new Uri(imagePath, UriKind.Absolute);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
