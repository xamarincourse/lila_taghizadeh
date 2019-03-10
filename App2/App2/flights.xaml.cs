using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Core;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class flights : ContentPage
	{
    public flights()
    {
      InitializeComponent();
      this.BindingContext = new FlightInfo()
      {
        MovingTxt = "It's go time.",
        BoardingTime = "8:20 PM",
        DepartureGate = "B79",
        Departure = "SFO",
        Arrival = "LAX",
        Term = "1",
        ArraivalGate = "A5",
        Seat = "5A",
        Depart = DepartStatusEnum.ON_TIME,
        Status= StatusEnum.On_Time
      };
    }
    async void onViewBoardingPassClicked(object sender, EventArgs args)
    {
      await Navigation.PushModalAsync(new FlightsList());
    }

  }
}