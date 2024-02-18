using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    internal class Pilot
    {
        public int PilotId { get; set; }
        public string Name { get; set; }
        public ICollection<Flight> Flights { get; set; }
    }
}
