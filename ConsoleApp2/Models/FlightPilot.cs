using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    internal class FlightPilot
    {
        public int FlightId { get; set; }
        public Flight Flight { get; set; }

        public int PilotId { get; set; }
        public Pilot Pilot { get; set; }

    }
}
