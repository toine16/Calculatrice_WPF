using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace compteur_wpf.Convert
{
    class IntToColors : IValueConverter
    {
        public List<Color> myColors;

        public IntToColors()
        {
            myColors = new List<Color>();
            myColors.Add(Colors.Green);
            myColors.Add(Colors.Blue);
            myColors.Add(Colors.Chartreuse);
            myColors.Add(Colors.Chocolate);
            myColors.Add(Colors.HotPink);
            myColors.Add(Colors.Khaki);
            myColors.Add(Colors.LavenderBlush);
            myColors.Add(Colors.DarkGray);
            myColors.Add(Colors.SaddleBrown);
            myColors.Add(Colors.Green);
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return new SolidColorBrush(myColors[(int)value]);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
