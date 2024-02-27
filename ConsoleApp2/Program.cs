using LittleAirline.Models;

using var context = new AppDbContext();

var flightId = 1;
var aircraftId = 1;



//Flight flight = context.Flights.Find(flightId);
//Console.WriteLine("AircraftId: " + flight.AircraftId);

//Aircraft aircraft = context.Aircrafts.Find(aircraftId);
//flight.Aircraft = aircraft;
//Console.WriteLine("AircraftId: " + flight.Aircraft.AircraftId);



Flight flight = context.Flights.Find(flightId);
Console.WriteLine("AircraftId: " + flight.AircraftId);

flight.AircraftId = aircraftId;
Console.WriteLine("AircraftId: " + flight.AircraftId);


var count = context.SaveChanges();
Console.WriteLine("AircraftId: " + flight.AircraftId);

Console.WriteLine(count);
