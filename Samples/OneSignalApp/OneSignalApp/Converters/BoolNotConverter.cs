using System;
using System.Globalization;
using Xamarin.Forms;

namespace OneSignalApp.Converters
{

   public class BoolNotConverter : IValueConverter
   {
      public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
      {
         return !((bool)value);
      }

      public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
      {
         return !((bool)value);
      }
   }
}
