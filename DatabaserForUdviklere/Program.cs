using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;
using DatabaserForUdviklere.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations; // Ensure this uses your actual DbContext namespace

class Program
{
    static void Main(string[] args)
    {

        long counter1 = 0;
        long counter2 = 0;

       

            Console.WriteLine("Foreign Key assignment");

        for (int i = 0; i < 20; i++)
        {
            var stopwatch = Stopwatch.StartNew();
            using var context = new GlobalogDevelopmentContext();

            FlightTrack flightTrack = context.FlightTracks.Find(232894);
            flightTrack.FlightId = 10575174 + i;
            var count = context.SaveChanges();
            Console.WriteLine(count);
            stopwatch.Stop();

            Console.WriteLine("Elapsed time: " + stopwatch.ElapsedMilliseconds + " ms");

                if (i > 3)
                {
                counter2 = counter2 + stopwatch.ElapsedMilliseconds;
            }
        }

        Console.WriteLine("Object assignment");
        for (int i = 0; i < 20; i++)
        {
            var stopwatch = Stopwatch.StartNew();
            using var context = new GlobalogDevelopmentContext();

            Flight flight = context.Flights.Find(10275180 + i);
            FlightTrack flightTrack = context.FlightTracks.Find(232894);

            flightTrack.Flight = flight;

            var count = context.SaveChanges();
            Console.WriteLine(count);
            stopwatch.Stop();

            Console.WriteLine("Elapsed time: " + stopwatch.ElapsedMilliseconds + " ms");

            if (i > 3)
            {
                counter1 = counter1 + stopwatch.ElapsedMilliseconds;
            }

        }

        Console.WriteLine(counter1);
            Console.WriteLine(counter2);



       





        /*for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Iteration {i + 1}");

            // Apply migrations
            MigrateToLatest();

            // Rollback migrations
            RollbackToPrevious();
        }*/


        /*for (int i = 0; i < 10; i++)
        {
            var stopwatch = Stopwatch.StartNew();

            using var context = new GlobalogDevelopmentContext();

            foreach (var country in context.Countries)
            {
                country.Status = 9;
                // Console.WriteLine(country.Id);
            }

            var count = context.SaveChanges();

            stopwatch.Stop();

            Console.WriteLine("Elapsed time: " + stopwatch.ElapsedMilliseconds + " ms");
            Console.WriteLine(count);

        }*/



    }

    /*static void MigrateToLatest()
    {
        using var context = new GlobalogDevelopmentContext();
        var stopwatch = new Stopwatch();

        stopwatch.Start();
        context.Database.Migrate();
        stopwatch.Stop();

        Console.WriteLine($"Migration applied in {stopwatch.ElapsedMilliseconds} ms");
    }

    static void RollbackToPrevious()
    {
        using var context = new GlobalogDevelopmentContext();
        var stopwatch = new Stopwatch();

        stopwatch.Start();
        // Specify the target migration to rollback to. If rolling back all migrations, use "0"
        // For example, to rollback the last applied migration, replace "PreviousMigrationName" with the name of the migration you want to rollback to
        context.Database.GetService<IMigrator>().Migrate("0");
        stopwatch.Stop();

        Console.WriteLine($"Rollback completed in {stopwatch.ElapsedMilliseconds} ms");
    }*/


}
