using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
  public class EmbeddedImg : IMarkupExtension
  {
    public string ResourceId { get; set; }
    public object ProvideValue(IServiceProvider serviceProvider)
    {
      return ImageSource.FromResource(ResourceId);
    }
  }
}
