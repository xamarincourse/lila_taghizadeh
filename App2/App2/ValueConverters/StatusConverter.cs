using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Text;
using Xamarin.Forms;

namespace App2.ValueConverters
{
  public class StatusConverter : IValueConverter
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
          case StatusEnum.Arrived:
            return "labelStatusOk";
          case StatusEnum.On_Time:
            return "labelStatusOk";
          case StatusEnum.Delayed:
            return "labelStatusFail";
          default:
            return "labelStatusOk";
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
