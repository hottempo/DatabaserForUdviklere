using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    internal class Flight
    {
        public int FlightId { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }
        public int AircraftId { get; set; }
        public DateTime Takeoff { get; set; }
        public DateTime Landing { get; set; }

        public Aircraft Aircraft { get; set; }
        public ICollection<FlightPilot> FlightPilots { get; set; }
    }
}
