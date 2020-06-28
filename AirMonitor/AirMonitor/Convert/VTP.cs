using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using Xamarin.Forms;

namespace AirMonitor.Convert
{
    public class VTP : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!double.TryParse(value?.ToString(), out var result)) return value;

            return result * 100;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}