using System;
using System.Collections.Generic;
using System.Text;

namespace App2
{
    public class Flight
    {
      public LogoEnum  Airline { get; set; }
      public StatusEnum Status { get; set; }
      public string  FlightNumber { get; set; }
      public string  Arrival { get; set; }
      public string  STA { get; set; }
      public string  ETA { get; set; }
      public string  Terminal { get; set; }
    public string StatusStyle { get; set; } = "labelStatusOk";
  }
}
