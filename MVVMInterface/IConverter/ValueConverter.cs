using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace MVVMInterface
{
    [ValueConversion(typeof(int), typeof(String))]
    public class ValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string a = (string)value;
            int b;
            int.TryParse(a, out b);
            return b;
        }
        public object ConvertBack(object value, Type targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
