using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    internal class AppDbContext : DbContext
    {

        public DbSet<Pilot> Pilots { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Aircraft> Aircrafts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=airline.dk");
        

        // public AppDbContext(DbContextOptions<AppDbContext> options) : base (options) { }


    }
}
