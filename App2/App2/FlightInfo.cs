using System;
using System.Collections.Generic;
using System.Text;

namespace App2
{
    public class FlightInfo
    {
      public string MovingTxt { get; set; }
      public string BoardingTime { get; set; }
      public string DepartureGate { get; set; }
      public string Departure { get; set; }
      public string Arrival { get; set; }
      public string Term { get; set; }
      public string ArraivalGate { get; set; }
      public string Seat { get; set; }
      public DepartStatusEnum Depart { get; set; }
      public StatusEnum Status { get; set; }
  }
}
