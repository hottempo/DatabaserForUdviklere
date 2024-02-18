﻿// <auto-generated />
using System;
using ConsoleApp2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ConsoleApp2.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240218233131_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("ConsoleApp2.Models.Aircraft", b =>
                {
                    b.Property<int>("AircraftId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Registration")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AircraftId");

                    b.ToTable("Aircrafts");
                });

            modelBuilder.Entity("ConsoleApp2.Models.Flight", b =>
                {
                    b.Property<int>("FlightId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AircraftId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Departure")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Landing")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Takeoff")
                        .HasColumnType("TEXT");

                    b.HasKey("FlightId");

                    b.HasIndex("AircraftId");

                    b.ToTable("Flights");
                });

            modelBuilder.Entity("ConsoleApp2.Models.Pilot", b =>
                {
                    b.Property<int>("PilotId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PilotId");

                    b.ToTable("Pilots");
                });

            modelBuilder.Entity("FlightPilot", b =>
                {
                    b.Property<int>("FlightsFlightId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PilotsPilotId")
                        .HasColumnType("INTEGER");

                    b.HasKey("FlightsFlightId", "PilotsPilotId");

                    b.HasIndex("PilotsPilotId");

                    b.ToTable("FlightPilot");
                });

            modelBuilder.Entity("ConsoleApp2.Models.Flight", b =>
                {
                    b.HasOne("ConsoleApp2.Models.Aircraft", "Aircraft")
                        .WithMany("Flights")
                        .HasForeignKey("AircraftId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aircraft");
                });

            modelBuilder.Entity("FlightPilot", b =>
                {
                    b.HasOne("ConsoleApp2.Models.Flight", null)
                        .WithMany()
                        .HasForeignKey("FlightsFlightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsoleApp2.Models.Pilot", null)
                        .WithMany()
                        .HasForeignKey("PilotsPilotId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ConsoleApp2.Models.Aircraft", b =>
                {
                    b.Navigation("Flights");
                });
#pragma warning restore 612, 618
        }
    }
}
