// See https://aka.ms/new-console-template for more information
using DatabaserForUdviklere.Models;


using (var context = new GlobalogDevelopmentContext())
{
    var flight = context.Flights.Where(f => f.Id == 10108396);

    Console.WriteLine(flight.ToString());
}
