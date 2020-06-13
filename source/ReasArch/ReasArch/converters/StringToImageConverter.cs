using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Data;

namespace ReasArch.converters
{
    class StringToImageConverter : IValueConverter
    {
        public static string imagesPath;

        static StringToImageConverter()
        {
            imagesPath = Path.Combine(Directory.GetCurrentDirectory(), "..\\images\\");
        }

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
