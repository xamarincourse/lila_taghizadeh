using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Text;
using Xamarin.Forms;

namespace App2.ValueConverters
{
  public class AirlinesConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      if (value == null)
      {
        return "";
      }
      else
      {
        switch (value)
        {
          case LogoEnum.JetAirWayes:
            return ImageSource.FromResource("App2.Images.jetairways.png", typeof(AirlinesConverter).GetTypeInfo().Assembly);
          case LogoEnum.MahanAir:
            return ImageSource.FromResource("App2.Images.mahanairlogo.png", typeof(AirlinesConverter).GetTypeInfo().Assembly);
          default:
            return "";
        }
      }
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      throw new NotImplementedException();
    }
  }
}
