using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    internal class Aircraft
    {
        public int AircraftId { get; set; }
        public string Type { get; set; }
        public string Registration { get; set; }
        public ICollection<Flight> Flights { get; set; }
    }
}
