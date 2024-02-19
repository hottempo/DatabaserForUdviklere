using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    internal class AppDbContext : DbContext
    {

        public DbSet<Pilot> Pilots { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Aircraft> Aircrafts { get; set; }
        public DbSet<FlightPilot> FlightPilots { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=airline.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure the many-to-many relationship
            modelBuilder.Entity<FlightPilot>()
                .HasKey(fp => new { fp.FlightId, fp.PilotId });

            modelBuilder.Entity<FlightPilot>()
                .HasOne(fp => fp.Flight)
                .WithMany(f => f.FlightPilots)
                .HasForeignKey(fp => fp.FlightId);

            modelBuilder.Entity<FlightPilot>()
                .HasOne(fp => fp.Pilot)
                .WithMany(p => p.FlightPilots)
                .HasForeignKey(fp => fp.PilotId);

            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            var aircrafts = JsonSerializer.Deserialize<List<Aircraft>>(File.ReadAllText("aircrafts.json"));
            var pilots = JsonSerializer.Deserialize<List<Pilot>>(File.ReadAllText("unique_pilots.json"));
            var flights = JsonSerializer.Deserialize<List<Flight>>(File.ReadAllText("flights.json"));
            var flightPilots = JsonSerializer.Deserialize<List<FlightPilot>>(File.ReadAllText("flightPilot.json"));

            modelBuilder.Entity<Aircraft>().HasData(aircrafts);
            modelBuilder.Entity<Pilot>().HasData(pilots);
            modelBuilder.Entity<Flight>().HasData(flights);
            modelBuilder.Entity<FlightPilot>().HasData(flightPilots);
        }

        // public AppDbContext(DbContextOptions<AppDbContext> options) : base (options) { }


    }
}
