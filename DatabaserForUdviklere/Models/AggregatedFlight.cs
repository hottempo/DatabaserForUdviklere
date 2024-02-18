using System;
using System.Collections.Generic;

namespace DatabaserForUdviklere.Models;

public partial class AggregatedFlight
{
    public int Id { get; set; }

    public int? FlightId { get; set; }

    public int? FlightRelationId { get; set; }

    public int? UserId { get; set; }

    public int? OwnerId { get; set; }

    public string? OwnerName { get; set; }

    public DateTime? FlightCreatedAt { get; set; }

    public DateTime? FlightUpdatedAt { get; set; }

    public DateTime? FlightRelationCreatedAt { get; set; }

    public string? DepartureAirportName { get; set; }

    public string? ArrivalAirportName { get; set; }

    public int? DepartureAirportId { get; set; }

    public int? ArrivalAirportId { get; set; }

    public string? DepartureAirportIata { get; set; }

    public string? ArrivalAirportIata { get; set; }

    public string? DepartureAirportIcao { get; set; }

    public string? ArrivalAirportIcao { get; set; }

    public string? FlightName { get; set; }

    public DateTime? FlightOffBlock { get; set; }

    public DateTime? FlightOnBlock { get; set; }

    public DateTime? FlightDepartureTime { get; set; }

    public DateTime? FlightArrivalTime { get; set; }

    public int? FlightBlockTime { get; set; }

    public int? FlightAirTime { get; set; }

    public int? FlightDayMinutes { get; set; }

    public int? FlightNightMinutes { get; set; }

    public bool? NightLanding { get; set; }

    public string? FlightType { get; set; }

    public int? AcId { get; set; }

    public string? AcRegistrationCode { get; set; }

    public string? AcManufacturerName { get; set; }

    public int? AcModelId { get; set; }

    public string? AcModelName { get; set; }

    public decimal? FlightRadiation { get; set; }

    public string? UserName { get; set; }

    public string? UserDefaultRoleName { get; set; }

    public string? FlightRelationRoleName { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public decimal? DepartureAirportLatitude { get; set; }

    public decimal? DepartureAirportLongitude { get; set; }

    public decimal? ArrivalAirportLatitude { get; set; }

    public decimal? ArrivalAirportLongitude { get; set; }

    public string? ArrivalAirportCountryName { get; set; }

    public string? ArrivalAirportProvinceName { get; set; }

    public int? ArrivalAirportRunwayLength { get; set; }

    public int? ArrivalAirportRunwayAltitude { get; set; }

    public int? ArrivalAirportGmtOffset { get; set; }

    public string? DepartureAirportCountryName { get; set; }

    public string? DepartureAirportProvinceName { get; set; }

    public int? DepartureAirportRunwayLength { get; set; }

    public int? DepartureAirportRunwayAltitude { get; set; }

    public int? DepartureAirportGmtOffset { get; set; }

    public int? AcEngineCount { get; set; }

    public int? FlightRelationRoleId { get; set; }

    public DateTime? UserPregDeclAt { get; set; }

    public string? RadSource { get; set; }
}
