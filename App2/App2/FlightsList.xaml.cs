using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FlightsList : ContentPage
	{
		public FlightsList ()
		{
			InitializeComponent ();
      this.BindingContext = new List<Flight>() {
        new Flight()
        {
          Airline = LogoEnum.JetAirWayes,
          Status= StatusEnum.Arrived,
          FlightNumber="9YY2254",
          Arrival="London",
          STA="14:20",
          ETA="14:35",
          Terminal="T3"
        },
        new Flight()
        {
          Airline = LogoEnum.MahanAir,
          Status=StatusEnum.Arrived,
          FlightNumber="9YY2254",
          Arrival="Paris",
          STA="14:20",
          ETA="14:35",
          Terminal="T3"
        },
        new Flight()
        {
          Airline = LogoEnum.JetAirWayes,
          Status=StatusEnum.Delayed,
          FlightNumber="9YY2254",
          Arrival="Dubai",
          STA="14:20",
          ETA="14:35",
          Terminal="T3"
        },
         new Flight()
        {
          Airline = LogoEnum.MahanAir,
          Status=StatusEnum.Arrived,
          FlightNumber="9YY2254",
          Arrival="New York",
          STA="14:20",
          ETA="14:35",
          Terminal="T3"
        },
          new Flight()
        {
           Airline = LogoEnum.MahanAir,
          Status=StatusEnum.Arrived,
          FlightNumber="9YY2254",
          Arrival="Italy",
          STA="14:20",
          ETA="14:35",
          Terminal="T3"
        }
      };
		}
	}
}