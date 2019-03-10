using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace App2.ValueConverters
{
  public class DepartConverter : IValueConverter
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
          case DepartStatusEnum.ON_TIME:
            return "\uf00c";
          case DepartStatusEnum.Delayed:
            return "\uf00d";
          default:
            return "\uf00c";
        }

        //return new Style(typeof(Label))
        //{
        //  Setters = {
        //    new Setter(){Property="TextColor", Value="Red"}
        //  }
        //};
      }
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      throw new NotImplementedException();
    }
  }
}
