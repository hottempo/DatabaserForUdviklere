// See https://aka.ms/new-console-template for more information
using DatabaserForUdviklere.Models;
using System.Reflection;


using (var context = new GlobalogDevelopmentContext())
{
    var flight = context.Flights.FirstOrDefault(f => f.Id == 10108396);
    if (flight != null)
    {
        PropertyInfo[] properties = flight.GetType().GetProperties();

        foreach (PropertyInfo property in properties)
        {
            object value = property.GetValue(flight, null) ?? "null";
            Console.WriteLine($"{property.Name}: {value}");
        }
    }
    else
    {
        Console.WriteLine("Flight not found.");
    }
}



