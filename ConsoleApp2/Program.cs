using ConsoleApp2.Models;

using var context = new AppDbContext();

var flights = context.Flights.Where(f => f.FlightPilots.Any(fp => fp.Pilot.Name == "Eric Lopez")).ToList();

Console.WriteLine(flights.Count);

Pilot pilot = context.Pilots.First();
Console.WriteLine(pilot.Name);