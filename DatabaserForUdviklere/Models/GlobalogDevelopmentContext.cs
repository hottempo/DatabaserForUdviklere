using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DatabaserForUdviklere.Models;

public partial class GlobalogDevelopmentContext : DbContext
{
    public GlobalogDevelopmentContext()
    {
    }

    public GlobalogDevelopmentContext(DbContextOptions<GlobalogDevelopmentContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ActiveAdminComment> ActiveAdminComments { get; set; }

    public virtual DbSet<AeroDataBoxAircraft> AeroDataBoxAircrafts { get; set; }

    public virtual DbSet<AggregatedFlight> AggregatedFlights { get; set; }

    public virtual DbSet<AhoyEvent> AhoyEvents { get; set; }

    public virtual DbSet<AhoyVisit> AhoyVisits { get; set; }

    public virtual DbSet<AirAtlantaFeb16ToFeb18> AirAtlantaFeb16ToFeb18s { get; set; }

    public virtual DbSet<Aircraft> Aircrafts { get; set; }

    public virtual DbSet<AircraftCategory> AircraftCategories { get; set; }

    public virtual DbSet<AircraftManufacturer> AircraftManufacturers { get; set; }

    public virtual DbSet<AircraftModel> AircraftModels { get; set; }

    public virtual DbSet<AircraftProfile> AircraftProfiles { get; set; }

    public virtual DbSet<Airport> Airports { get; set; }

    public virtual DbSet<ApiRequest> ApiRequests { get; set; }

    public virtual DbSet<ApproachType> ApproachTypes { get; set; }

    public virtual DbSet<CopyOfPostLaunchFlight> CopyOfPostLaunchFlights { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<CustomerStat> CustomerStats { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<FileLines2> FileLines2s { get; set; }

    public virtual DbSet<Flight> Flights { get; set; }

    public virtual DbSet<FlightAwareAirport> FlightAwareAirports { get; set; }

    public virtual DbSet<FlightAwareFlight> FlightAwareFlights { get; set; }

    public virtual DbSet<FlightRelation> FlightRelations { get; set; }

    public virtual DbSet<FlightTrack> FlightTracks { get; set; }

    public virtual DbSet<FlightType> FlightTypes { get; set; }

    public virtual DbSet<FlightsOldSystem> FlightsOldSystems { get; set; }

    public virtual DbSet<Idp> Idps { get; set; }

    public virtual DbSet<IdpOwner> IdpOwners { get; set; }

    public virtual DbSet<LoadWollenbergConstant> LoadWollenbergConstants { get; set; }

    public virtual DbSet<Logbook> Logbooks { get; set; }

    public virtual DbSet<Logbook2> Logbook2s { get; set; }

    public virtual DbSet<LoginAttempt> LoginAttempts { get; set; }

    public virtual DbSet<MailSubscription> MailSubscriptions { get; set; }

    public virtual DbSet<MeasuredRadiation> MeasuredRadiations { get; set; }

    public virtual DbSet<MeasurementLocation> MeasurementLocations { get; set; }

    public virtual DbSet<Owner> Owners { get; set; }

    public virtual DbSet<OwnerType> OwnerTypes { get; set; }

    public virtual DbSet<PostLaunchOldSystemFlight> PostLaunchOldSystemFlights { get; set; }

    public virtual DbSet<PreviousAircraftExperience> PreviousAircraftExperiences { get; set; }

    public virtual DbSet<PreviousEmployment> PreviousEmployments { get; set; }

    public virtual DbSet<RadDiff> RadDiffs { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<SchemaMigration> SchemaMigrations { get; set; }

    public virtual DbSet<SecondaryRole> SecondaryRoles { get; set; }

    public virtual DbSet<StukReportDreamjet2015> StukReportDreamjet2015s { get; set; }

    public virtual DbSet<StukReportJettime2015> StukReportJettime2015s { get; set; }

    public virtual DbSet<StukReportJettime2016> StukReportJettime2016s { get; set; }

    public virtual DbSet<ThresholdExceedMailTemplate> ThresholdExceedMailTemplates { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserLink> UserLinks { get; set; }

    public virtual DbSet<Version> Versions { get; set; }

    public virtual DbSet<VwAircraft> VwAircrafts { get; set; }

    public virtual DbSet<WideroeMissingCrewOperation> WideroeMissingCrewOperations { get; set; }

    public virtual DbSet<WorldRadiationCoefficient> WorldRadiationCoefficients { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=globalog_development;Username=postgres;Password=password");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ActiveAdminComment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("active_admin_comments_pkey");

            entity.ToTable("active_admin_comments");

            entity.HasIndex(e => e.Namespace, "index_active_admin_comments_on_namespace");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AuthorId).HasColumnName("author_id");
            entity.Property(e => e.AuthorType)
                .HasColumnType("character varying")
                .HasColumnName("author_type");
            entity.Property(e => e.Body).HasColumnName("body");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Namespace)
                .HasColumnType("character varying")
                .HasColumnName("namespace");
            entity.Property(e => e.ResourceId).HasColumnName("resource_id");
            entity.Property(e => e.ResourceType)
                .HasColumnType("character varying")
                .HasColumnName("resource_type");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<AeroDataBoxAircraft>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("aero_data_box_aircrafts_pkey");

            entity.ToTable("aero_data_box_aircrafts");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AirlineName)
                .HasColumnType("character varying")
                .HasColumnName("airline_name");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.IataCodeLong)
                .HasColumnType("character varying")
                .HasColumnName("iata_code_long");
            entity.Property(e => e.IataCodeShort)
                .HasColumnType("character varying")
                .HasColumnName("iata_code_short");
            entity.Property(e => e.Model)
                .HasColumnType("character varying")
                .HasColumnName("model");
            entity.Property(e => e.ModelCode)
                .HasColumnType("character varying")
                .HasColumnName("model_code");
            entity.Property(e => e.Reg)
                .HasColumnType("character varying")
                .HasColumnName("reg");
            entity.Property(e => e.TypeName)
                .HasColumnType("character varying")
                .HasColumnName("type_name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<AggregatedFlight>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("aggregated_flights_pkey");

            entity.ToTable("aggregated_flights");

            entity.HasIndex(e => e.AcRegistrationCode, "index_aggregated_flights_on_ac_registration_code");

            entity.HasIndex(e => e.CreatedAt, "index_aggregated_flights_on_created_at").HasFilter("(flight_relation_id IS NULL)");

            entity.HasIndex(e => e.CreatedAt, "index_aggregated_flights_on_created_at2");

            entity.HasIndex(e => e.FlightId, "index_aggregated_flights_on_flight_id");

            entity.HasIndex(e => new { e.FlightId, e.FlightRelationId }, "index_aggregated_flights_on_flight_id_and_flight_relation_id").IsUnique();

            entity.HasIndex(e => e.FlightOffBlock, "index_aggregated_flights_on_flight_off_block");

            entity.HasIndex(e => e.FlightRelationId, "index_aggregated_flights_on_flight_relation_id").IsUnique();

            entity.HasIndex(e => e.FlightRelationRoleName, "index_aggregated_flights_on_flight_relation_role_name");

            entity.HasIndex(e => e.FlightUpdatedAt, "index_aggregated_flights_on_flight_updated_at");

            entity.HasIndex(e => e.OwnerId, "index_aggregated_flights_on_owner_id");

            entity.HasIndex(e => e.UserId, "index_aggregated_flights_on_user_id");

            entity.HasIndex(e => e.UserPregDeclAt, "index_aggregated_flights_on_user_preg_decl_at");

            entity.HasIndex(e => e.FlightOffBlock, "index_off_block_f_rel_null").HasFilter("(flight_relation_id IS NULL)");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AcEngineCount).HasColumnName("ac_engine_count");
            entity.Property(e => e.AcId).HasColumnName("ac_id");
            entity.Property(e => e.AcManufacturerName)
                .HasColumnType("character varying")
                .HasColumnName("ac_manufacturer_name");
            entity.Property(e => e.AcModelId).HasColumnName("ac_model_id");
            entity.Property(e => e.AcModelName)
                .HasColumnType("character varying")
                .HasColumnName("ac_model_name");
            entity.Property(e => e.AcRegistrationCode)
                .HasColumnType("character varying")
                .HasColumnName("ac_registration_code");
            entity.Property(e => e.ArrivalAirportCountryName)
                .HasColumnType("character varying")
                .HasColumnName("arrival_airport_country_name");
            entity.Property(e => e.ArrivalAirportGmtOffset).HasColumnName("arrival_airport_gmt_offset");
            entity.Property(e => e.ArrivalAirportIata)
                .HasColumnType("character varying")
                .HasColumnName("arrival_airport_iata");
            entity.Property(e => e.ArrivalAirportIcao)
                .HasColumnType("character varying")
                .HasColumnName("arrival_airport_icao");
            entity.Property(e => e.ArrivalAirportId).HasColumnName("arrival_airport_id");
            entity.Property(e => e.ArrivalAirportLatitude)
                .HasPrecision(10, 6)
                .HasColumnName("arrival_airport_latitude");
            entity.Property(e => e.ArrivalAirportLongitude)
                .HasPrecision(10, 6)
                .HasColumnName("arrival_airport_longitude");
            entity.Property(e => e.ArrivalAirportName)
                .HasColumnType("character varying")
                .HasColumnName("arrival_airport_name");
            entity.Property(e => e.ArrivalAirportProvinceName)
                .HasColumnType("character varying")
                .HasColumnName("arrival_airport_province_name");
            entity.Property(e => e.ArrivalAirportRunwayAltitude).HasColumnName("arrival_airport_runway_altitude");
            entity.Property(e => e.ArrivalAirportRunwayLength).HasColumnName("arrival_airport_runway_length");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.DepartureAirportCountryName)
                .HasColumnType("character varying")
                .HasColumnName("departure_airport_country_name");
            entity.Property(e => e.DepartureAirportGmtOffset).HasColumnName("departure_airport_gmt_offset");
            entity.Property(e => e.DepartureAirportIata)
                .HasColumnType("character varying")
                .HasColumnName("departure_airport_iata");
            entity.Property(e => e.DepartureAirportIcao)
                .HasColumnType("character varying")
                .HasColumnName("departure_airport_icao");
            entity.Property(e => e.DepartureAirportId).HasColumnName("departure_airport_id");
            entity.Property(e => e.DepartureAirportLatitude)
                .HasPrecision(10, 6)
                .HasColumnName("departure_airport_latitude");
            entity.Property(e => e.DepartureAirportLongitude)
                .HasPrecision(10, 6)
                .HasColumnName("departure_airport_longitude");
            entity.Property(e => e.DepartureAirportName)
                .HasColumnType("character varying")
                .HasColumnName("departure_airport_name");
            entity.Property(e => e.DepartureAirportProvinceName)
                .HasColumnType("character varying")
                .HasColumnName("departure_airport_province_name");
            entity.Property(e => e.DepartureAirportRunwayAltitude).HasColumnName("departure_airport_runway_altitude");
            entity.Property(e => e.DepartureAirportRunwayLength).HasColumnName("departure_airport_runway_length");
            entity.Property(e => e.FlightAirTime).HasColumnName("flight_air_time");
            entity.Property(e => e.FlightArrivalTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("flight_arrival_time");
            entity.Property(e => e.FlightBlockTime).HasColumnName("flight_block_time");
            entity.Property(e => e.FlightCreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("flight_created_at");
            entity.Property(e => e.FlightDayMinutes).HasColumnName("flight_day_minutes");
            entity.Property(e => e.FlightDepartureTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("flight_departure_time");
            entity.Property(e => e.FlightId).HasColumnName("flight_id");
            entity.Property(e => e.FlightName)
                .HasColumnType("character varying")
                .HasColumnName("flight_name");
            entity.Property(e => e.FlightNightMinutes).HasColumnName("flight_night_minutes");
            entity.Property(e => e.FlightOffBlock)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("flight_off_block");
            entity.Property(e => e.FlightOnBlock)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("flight_on_block");
            entity.Property(e => e.FlightRadiation).HasColumnName("flight_radiation");
            entity.Property(e => e.FlightRelationCreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("flight_relation_created_at");
            entity.Property(e => e.FlightRelationId).HasColumnName("flight_relation_id");
            entity.Property(e => e.FlightRelationRoleId).HasColumnName("flight_relation_role_id");
            entity.Property(e => e.FlightRelationRoleName)
                .HasColumnType("character varying")
                .HasColumnName("flight_relation_role_name");
            entity.Property(e => e.FlightType)
                .HasColumnType("character varying")
                .HasColumnName("flight_type");
            entity.Property(e => e.FlightUpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("flight_updated_at");
            entity.Property(e => e.NightLanding).HasColumnName("night_landing");
            entity.Property(e => e.OwnerId).HasColumnName("owner_id");
            entity.Property(e => e.OwnerName)
                .HasColumnType("character varying")
                .HasColumnName("owner_name");
            entity.Property(e => e.RadSource)
                .HasColumnType("character varying")
                .HasColumnName("rad_source");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserDefaultRoleName)
                .HasColumnType("character varying")
                .HasColumnName("user_default_role_name");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.UserName)
                .HasColumnType("character varying")
                .HasColumnName("user_name");
            entity.Property(e => e.UserPregDeclAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("user_preg_decl_at");
        });

        modelBuilder.Entity<AhoyEvent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ahoy_events_pkey");

            entity.ToTable("ahoy_events");

            entity.HasIndex(e => new { e.Name, e.Time }, "index_ahoy_events_on_name_and_time");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Properties)
                .HasColumnType("jsonb")
                .HasColumnName("properties");
            entity.Property(e => e.Time)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("time");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.VisitId).HasColumnName("visit_id");
        });

        modelBuilder.Entity<AhoyVisit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ahoy_visits_pkey");

            entity.ToTable("ahoy_visits");

            entity.HasIndex(e => e.VisitToken, "index_ahoy_visits_on_visit_token").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AppVersion)
                .HasColumnType("character varying")
                .HasColumnName("app_version");
            entity.Property(e => e.Browser)
                .HasColumnType("character varying")
                .HasColumnName("browser");
            entity.Property(e => e.City)
                .HasColumnType("character varying")
                .HasColumnName("city");
            entity.Property(e => e.Country)
                .HasColumnType("character varying")
                .HasColumnName("country");
            entity.Property(e => e.DeviceType)
                .HasColumnType("character varying")
                .HasColumnName("device_type");
            entity.Property(e => e.Ip)
                .HasColumnType("character varying")
                .HasColumnName("ip");
            entity.Property(e => e.LandingPage).HasColumnName("landing_page");
            entity.Property(e => e.Latitude)
                .HasPrecision(10, 8)
                .HasColumnName("latitude");
            entity.Property(e => e.Longitude)
                .HasPrecision(11, 8)
                .HasColumnName("longitude");
            entity.Property(e => e.Os)
                .HasColumnType("character varying")
                .HasColumnName("os");
            entity.Property(e => e.OsVersion)
                .HasColumnType("character varying")
                .HasColumnName("os_version");
            entity.Property(e => e.Platform)
                .HasColumnType("character varying")
                .HasColumnName("platform");
            entity.Property(e => e.Referrer).HasColumnName("referrer");
            entity.Property(e => e.ReferringDomain)
                .HasColumnType("character varying")
                .HasColumnName("referring_domain");
            entity.Property(e => e.Region)
                .HasColumnType("character varying")
                .HasColumnName("region");
            entity.Property(e => e.StartedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("started_at");
            entity.Property(e => e.UserAgent).HasColumnName("user_agent");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.UtmCampaign)
                .HasColumnType("character varying")
                .HasColumnName("utm_campaign");
            entity.Property(e => e.UtmContent)
                .HasColumnType("character varying")
                .HasColumnName("utm_content");
            entity.Property(e => e.UtmMedium)
                .HasColumnType("character varying")
                .HasColumnName("utm_medium");
            entity.Property(e => e.UtmSource)
                .HasColumnType("character varying")
                .HasColumnName("utm_source");
            entity.Property(e => e.UtmTerm)
                .HasColumnType("character varying")
                .HasColumnName("utm_term");
            entity.Property(e => e.VisitToken)
                .HasColumnType("character varying")
                .HasColumnName("visit_token");
            entity.Property(e => e.VisitorToken)
                .HasColumnType("character varying")
                .HasColumnName("visitor_token");
        });

        modelBuilder.Entity<AirAtlantaFeb16ToFeb18>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("air_atlanta_feb16_to_feb18");

            entity.Property(e => e.AcReg)
                .HasMaxLength(10)
                .HasColumnName("ac_reg");
            entity.Property(e => e.DepartureIata)
                .HasMaxLength(10)
                .HasColumnName("departure_iata");
            entity.Property(e => e.FlightNo)
                .HasMaxLength(20)
                .HasColumnName("flight_no");
            entity.Property(e => e.FlightSeq)
                .HasMaxLength(10)
                .HasColumnName("flight_seq");
            entity.Property(e => e.OffBlock)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("off_block");
            entity.Property(e => e.Radiation).HasColumnName("radiation");
        });

        modelBuilder.Entity<Aircraft>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("aircrafts_pkey");

            entity.ToTable("aircrafts");

            entity.HasIndex(e => e.RegistrationCode, "index_aircrafts_on_registration_code");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AeroDataBoxAircraftId).HasColumnName("aero_data_box_aircraft_id");
            entity.Property(e => e.AircraftModelId).HasColumnName("aircraft_model_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.IsSimulator)
                .HasDefaultValue(false)
                .HasColumnName("is_simulator");
            entity.Property(e => e.ModelConfirmed)
                .HasDefaultValue(false)
                .HasColumnName("model_confirmed");
            entity.Property(e => e.OwnerId).HasColumnName("owner_id");
            entity.Property(e => e.RegistrationCode)
                .HasColumnType("character varying")
                .HasColumnName("registration_code");
            entity.Property(e => e.SkipRadCalc)
                .HasDefaultValue(false)
                .HasColumnName("skip_rad_calc");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<AircraftCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("aircraft_categories_pkey");

            entity.ToTable("aircraft_categories");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.ShortName)
                .HasColumnType("character varying")
                .HasColumnName("short_name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<AircraftManufacturer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("aircraft_manufacturers_pkey");

            entity.ToTable("aircraft_manufacturers");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<AircraftModel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("aircraft_models_pkey");

            entity.ToTable("aircraft_models");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AircraftCategoryId).HasColumnName("aircraft_category_id");
            entity.Property(e => e.AircraftManufacturerId).HasColumnName("aircraft_manufacturer_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Engines).HasColumnName("engines");
            entity.Property(e => e.IcaoCode)
                .HasColumnType("character varying")
                .HasColumnName("icao_code");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.Wtc)
                .HasColumnType("character varying")
                .HasColumnName("wtc");
        });

        modelBuilder.Entity<AircraftProfile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("aircraft_profiles_pkey");

            entity.ToTable("aircraft_profiles");

            entity.HasIndex(e => e.AircraftModelId, "index_aircraft_profiles_on_aircraft_model_id");

            entity.HasIndex(e => e.Altitude, "index_aircraft_profiles_on_altitude");

            entity.HasIndex(e => e.Minutes, "index_aircraft_profiles_on_minutes");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AircraftModelId).HasColumnName("aircraft_model_id");
            entity.Property(e => e.Altitude).HasColumnName("altitude");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Minutes).HasColumnName("minutes");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Airport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("airports_pkey");

            entity.ToTable("airports");

            entity.HasIndex(e => e.IataCode, "index_airports_on_iata_code");

            entity.HasIndex(e => e.IcaoCode, "index_airports_on_icao_code");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CountryId).HasColumnName("country_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.GmtOffset).HasColumnName("gmt_offset");
            entity.Property(e => e.IataCode)
                .HasColumnType("character varying")
                .HasColumnName("iata_code");
            entity.Property(e => e.IcaoCode)
                .HasColumnType("character varying")
                .HasColumnName("icao_code");
            entity.Property(e => e.Latitude)
                .HasPrecision(10, 6)
                .HasColumnName("latitude");
            entity.Property(e => e.Longitude)
                .HasPrecision(10, 6)
                .HasColumnName("longitude");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.RunwayAltitude).HasColumnName("runway_altitude");
            entity.Property(e => e.RunwayLength).HasColumnName("runway_length");
            entity.Property(e => e.State)
                .HasDefaultValueSql("'draft'::character varying")
                .HasColumnType("character varying")
                .HasColumnName("state");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<ApiRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("api_requests_pkey");

            entity.ToTable("api_requests");

            entity.HasIndex(e => e.OwnerId, "index_api_requests_on_owner_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.HttpStatusCode)
                .HasColumnType("character varying")
                .HasColumnName("http_status_code");
            entity.Property(e => e.Message).HasColumnName("message");
            entity.Property(e => e.OwnerId).HasColumnName("owner_id");
            entity.Property(e => e.Params).HasColumnName("params");
            entity.Property(e => e.Status)
                .HasColumnType("character varying")
                .HasColumnName("status");
            entity.Property(e => e.Task)
                .HasColumnType("character varying")
                .HasColumnName("task");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Owner).WithMany(p => p.ApiRequests)
                .HasForeignKey(d => d.OwnerId)
                .HasConstraintName("fk_rails_b5b779aad8");
        });

        modelBuilder.Entity<ApproachType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("approach_types_pkey");

            entity.ToTable("approach_types");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.ShortName)
                .HasColumnType("character varying")
                .HasColumnName("short_name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<CopyOfPostLaunchFlight>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("copy_of_post_launch_flights");

            entity.Property(e => e.AcReg)
                .HasMaxLength(200)
                .HasColumnName("ac_reg");
            entity.Property(e => e.AircraftId).HasColumnName("aircraft_id");
            entity.Property(e => e.AircraftModelId).HasColumnName("aircraft_model_id");
            entity.Property(e => e.AlternativeFlghts).HasColumnName("alternative_flghts");
            entity.Property(e => e.Concurrent).HasColumnName("concurrent");
            entity.Property(e => e.Csv)
                .HasMaxLength(250)
                .HasColumnName("csv");
            entity.Property(e => e.DepartureCode)
                .HasMaxLength(30)
                .HasColumnName("departure_code");
            entity.Property(e => e.FlightName)
                .HasMaxLength(30)
                .HasColumnName("flight_name");
            entity.Property(e => e.FlightSeq).HasColumnName("flight_seq");
            entity.Property(e => e.MatchedFlight).HasColumnName("matched_flight");
            entity.Property(e => e.Message)
                .HasMaxLength(500)
                .HasColumnName("message");
            entity.Property(e => e.OffBlock)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("off_block");
            entity.Property(e => e.Radiation)
                .HasPrecision(10, 6)
                .HasColumnName("radiation");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("countries_pkey");

            entity.ToTable("countries");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Iso2Code)
                .HasColumnType("character varying")
                .HasColumnName("iso_2_code");
            entity.Property(e => e.IsoCode)
                .HasColumnType("character varying")
                .HasColumnName("iso_code");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Province)
                .HasColumnType("character varying")
                .HasColumnName("province");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<CustomerStat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("customer_stats_pkey");

            entity.ToTable("customer_stats");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActiveAc).HasColumnName("active_ac");
            entity.Property(e => e.ActiveCrew).HasColumnName("active_crew");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CrewOps).HasColumnName("crew_ops");
            entity.Property(e => e.CrewOpsWithRad)
                .HasDefaultValue(0)
                .HasColumnName("crew_ops_with_rad");
            entity.Property(e => e.CrewSimulatorOps)
                .HasDefaultValue(0)
                .HasColumnName("crew_simulator_ops");
            entity.Property(e => e.Flights).HasColumnName("flights");
            entity.Property(e => e.Month)
                .HasColumnType("character varying")
                .HasColumnName("month");
            entity.Property(e => e.OwnerId).HasColumnName("owner_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("events_pkey");

            entity.ToTable("events");

            entity.HasIndex(e => e.CreatedAt, "index_events_on_created_at");

            entity.HasIndex(e => e.EventType, "index_events_on_event_type");

            entity.HasIndex(e => e.LogLevel, "index_events_on_log_level");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.EventType)
                .HasColumnType("character varying")
                .HasColumnName("event_type");
            entity.Property(e => e.Info)
                .HasColumnType("jsonb")
                .HasColumnName("info");
            entity.Property(e => e.LogLevel).HasColumnName("log_level");
            entity.Property(e => e.Payload)
                .HasColumnType("jsonb")
                .HasColumnName("payload");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<FileLines2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("file_lines2");

            entity.Property(e => e.AircraftId).HasColumnName("aircraft_id");
            entity.Property(e => e.CallSign)
                .HasColumnType("character varying")
                .HasColumnName("call_sign");
            entity.Property(e => e.Deletion).HasColumnName("deletion");
            entity.Property(e => e.DepPort)
                .HasColumnType("character varying")
                .HasColumnName("dep_port");
            entity.Property(e => e.DepartureAirportId).HasColumnName("departure_airport_id");
            entity.Property(e => e.FileLines).HasColumnName("file_lines");
            entity.Property(e => e.FileMtime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("file_mtime");
            entity.Property(e => e.FileName)
                .HasColumnType("character varying")
                .HasColumnName("file_name");
            entity.Property(e => e.FileSize).HasColumnName("file_size");
            entity.Property(e => e.FileType)
                .HasColumnType("character varying")
                .HasColumnName("file_type");
            entity.Property(e => e.FtpUsername)
                .HasColumnType("character varying")
                .HasColumnName("ftp_username");
            entity.Property(e => e.LineContent)
                .HasColumnType("character varying")
                .HasColumnName("line_content");
            entity.Property(e => e.LineNumber).HasColumnName("line_number");
            entity.Property(e => e.LoadId)
                .HasColumnType("character varying")
                .HasColumnName("load_id");
            entity.Property(e => e.OffBlock)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("off_block");
            entity.Property(e => e.OffBlockRaw)
                .HasColumnType("character varying")
                .HasColumnName("off_block_raw");
            entity.Property(e => e.OwnerId).HasColumnName("owner_id");
        });

        modelBuilder.Entity<Flight>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("flights_pkey");

            entity.ToTable("flights");

            entity.HasIndex(e => new { e.Name, e.DepartureAirportId, e.OffBlock }, "index_flights_combined");

            entity.HasIndex(e => e.AircraftId, "index_flights_on_aircraft_id");

            entity.HasIndex(e => e.ApproachTypeId, "index_flights_on_approach_type_id");

            entity.HasIndex(e => e.ArrivalAirportId, "index_flights_on_arrival_airport_id");

            entity.HasIndex(e => e.CreatedAt, "index_flights_on_created_at");

            entity.HasIndex(e => e.DepartureAirportId, "index_flights_on_departure_airport_id");

            entity.HasIndex(e => e.FlightTypeId, "index_flights_on_flight_type_id");

            entity.HasIndex(e => e.Id, "index_flights_on_id").HasFilter("((status)::text = 'COMMITED'::text)");

            entity.HasIndex(e => e.OffBlock, "index_flights_on_off_block");

            entity.HasIndex(e => e.OnBlock, "index_flights_on_on_block");

            entity.HasIndex(e => e.OwnerId, "index_flights_on_owner_id");

            entity.HasIndex(e => e.UpdatedAt, "index_flights_on_updated_at");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AircraftId).HasColumnName("aircraft_id");
            entity.Property(e => e.ApproachTypeId).HasColumnName("approach_type_id");
            entity.Property(e => e.ArrivalAirportId).HasColumnName("arrival_airport_id");
            entity.Property(e => e.ArrivalTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("arrival_time");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.DepartureAirportId).HasColumnName("departure_airport_id");
            entity.Property(e => e.DepartureTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("departure_time");
            entity.Property(e => e.FallbackAcId).HasColumnName("fallback_ac_id");
            entity.Property(e => e.FlightAwareFlightId).HasColumnName("flight_aware_flight_id");
            entity.Property(e => e.FlightTypeId).HasColumnName("flight_type_id");
            entity.Property(e => e.ForeignId)
                .HasColumnType("character varying")
                .HasColumnName("foreign_id");
            entity.Property(e => e.GctRad).HasColumnName("gct_rad");
            entity.Property(e => e.LoadFilename)
                .HasColumnType("character varying")
                .HasColumnName("load_filename");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.NightLanding).HasColumnName("night_landing");
            entity.Property(e => e.Note)
                .HasColumnType("character varying")
                .HasColumnName("note");
            entity.Property(e => e.OffBlock)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("off_block");
            entity.Property(e => e.OnBlock)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("on_block");
            entity.Property(e => e.OwnerId).HasColumnName("owner_id");
            entity.Property(e => e.RadSource)
                .HasColumnType("character varying")
                .HasColumnName("rad_source");
            entity.Property(e => e.RadiationAmount)
                .HasPrecision(10, 6)
                .HasColumnName("radiation_amount");
            entity.Property(e => e.Recalc).HasColumnName("recalc");
            entity.Property(e => e.RouteDefinedBy)
                .HasDefaultValue(0)
                .HasColumnName("route_defined_by");
            entity.Property(e => e.RrtRad).HasColumnName("rrt_rad");
            entity.Property(e => e.Status)
                .HasColumnType("character varying")
                .HasColumnName("status");
            entity.Property(e => e.TotalDayMinutes).HasColumnName("total_day_minutes");
            entity.Property(e => e.TotalInstrMinutes).HasColumnName("total_instr_minutes");
            entity.Property(e => e.TotalNightMinutes).HasColumnName("total_night_minutes");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.WorkerStartedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("worker_started_at");
        });

        modelBuilder.Entity<FlightAwareAirport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("flight_aware_airports_pkey");

            entity.ToTable("flight_aware_airports");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.City)
                .HasColumnType("character varying")
                .HasColumnName("city");
            entity.Property(e => e.CountryCode)
                .HasColumnType("character varying")
                .HasColumnName("country_code");
            entity.Property(e => e.Elevation).HasColumnName("elevation");
            entity.Property(e => e.IataCode)
                .HasColumnType("character varying")
                .HasColumnName("iata_code");
            entity.Property(e => e.IcaoCode)
                .HasColumnType("character varying")
                .HasColumnName("icao_code");
            entity.Property(e => e.Latitude).HasColumnName("latitude");
            entity.Property(e => e.Longitude).HasColumnName("longitude");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Province)
                .HasColumnType("character varying")
                .HasColumnName("province");
            entity.Property(e => e.Timezone)
                .HasColumnType("character varying")
                .HasColumnName("timezone");
            entity.Property(e => e.WikiUrl)
                .HasColumnType("character varying")
                .HasColumnName("wiki_url");
        });

        modelBuilder.Entity<FlightAwareFlight>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("flight_aware_flights_pkey");

            entity.ToTable("flight_aware_flights");

            entity.HasIndex(e => e.FaIdent, "index_flight_aware_flights_on_fa_ident");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActualArrivalTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("actual_arrival_time");
            entity.Property(e => e.ActualBlockinTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("actual_blockin_time");
            entity.Property(e => e.ActualBlockoutTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("actual_blockout_time");
            entity.Property(e => e.ActualDepartureTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("actual_departure_time");
            entity.Property(e => e.Adhoc).HasColumnName("adhoc");
            entity.Property(e => e.Aircrafttype)
                .HasColumnType("character varying")
                .HasColumnName("aircrafttype");
            entity.Property(e => e.Airline)
                .HasColumnType("character varying")
                .HasColumnName("airline");
            entity.Property(e => e.AirlineIata)
                .HasColumnType("character varying")
                .HasColumnName("airline_iata");
            entity.Property(e => e.ArrivalDelay).HasColumnName("arrival_delay");
            entity.Property(e => e.AtcIdent)
                .HasColumnType("character varying")
                .HasColumnName("atc_ident");
            entity.Property(e => e.Blocked).HasColumnName("blocked");
            entity.Property(e => e.Cancelled).HasColumnName("cancelled");
            entity.Property(e => e.Codeshares)
                .HasColumnType("character varying")
                .HasColumnName("codeshares");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Datalink).HasColumnName("datalink");
            entity.Property(e => e.DepartureDelay).HasColumnName("departure_delay");
            entity.Property(e => e.Destination)
                .HasColumnType("character varying")
                .HasColumnName("destination");
            entity.Property(e => e.Diverted).HasColumnName("diverted");
            entity.Property(e => e.FaIdent)
                .HasColumnType("character varying")
                .HasColumnName("fa_ident");
            entity.Property(e => e.FiledArrivalTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("filed_arrival_time");
            entity.Property(e => e.FiledBlockinTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("filed_blockin_time");
            entity.Property(e => e.FiledBlockoutTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("filed_blockout_time");
            entity.Property(e => e.FiledDepartureTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("filed_departure_time");
            entity.Property(e => e.FiledEte).HasColumnName("filed_ete");
            entity.Property(e => e.FlightTracks)
                .HasColumnType("jsonb")
                .HasColumnName("flight_tracks");
            entity.Property(e => e.FlightType)
                .HasColumnType("character varying")
                .HasColumnName("flight_type");
            entity.Property(e => e.Flightnumber)
                .HasColumnType("character varying")
                .HasColumnName("flightnumber");
            entity.Property(e => e.FullAircrafttype)
                .HasColumnType("character varying")
                .HasColumnName("full_aircrafttype");
            entity.Property(e => e.Ident)
                .HasColumnType("character varying")
                .HasColumnName("ident");
            entity.Property(e => e.Origin)
                .HasColumnType("character varying")
                .HasColumnName("origin");
            entity.Property(e => e.OwnerId).HasColumnName("owner_id");
            entity.Property(e => e.Radiation).HasColumnName("radiation");
            entity.Property(e => e.Route)
                .HasColumnType("character varying")
                .HasColumnName("route");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.Status)
                .HasColumnType("character varying")
                .HasColumnName("status");
            entity.Property(e => e.Tailnumber)
                .HasColumnType("character varying")
                .HasColumnName("tailnumber");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<FlightRelation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("flight_relations_pkey");

            entity.ToTable("flight_relations");

            entity.HasIndex(e => new { e.FlightId, e.UserId, e.RoleId }, "index_flight_relations_combined");

            entity.HasIndex(e => e.FlightId, "index_flight_relations_on_flight_id");

            entity.HasIndex(e => new { e.FlightId, e.UserId }, "index_flight_relations_on_flight_id_and_user_id").IsUnique();

            entity.HasIndex(e => e.RoleId, "index_flight_relations_on_role_id");

            entity.HasIndex(e => e.UserId, "index_flight_relations_on_user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.FlightId).HasColumnName("flight_id");
            entity.Property(e => e.FlyingPilot).HasColumnName("flying_pilot");
            entity.Property(e => e.RoleId).HasColumnName("role_id");
            entity.Property(e => e.SecondaryRoleId).HasColumnName("secondary_role_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.UserRadiationAmount)
                .HasPrecision(10, 6)
                .HasColumnName("user_radiation_amount");
        });

        modelBuilder.Entity<FlightTrack>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("flight_tracks_pkey");

            entity.ToTable("flight_tracks");

            entity.HasIndex(e => e.FlightId, "index_flight_tracks_on_flight_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.FlightId).HasColumnName("flight_id");
            entity.Property(e => e.FlightTrackSteps)
                .HasColumnType("jsonb")
                .HasColumnName("flight_track_steps");
            entity.Property(e => e.Radiation).HasColumnName("radiation");
            entity.Property(e => e.TrackSource)
                .HasColumnType("character varying")
                .HasColumnName("track_source");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Flight).WithMany(p => p.FlightTracks)
                .HasForeignKey(d => d.FlightId)
                .HasConstraintName("fk_rails_19c21afc6a");
        });

        modelBuilder.Entity<FlightType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("flight_types_pkey");

            entity.ToTable("flight_types");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<FlightsOldSystem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("flights_old_system");

            entity.Property(e => e.ArrivalDatetime)
                .HasMaxLength(50)
                .HasColumnName("arrival_datetime");
            entity.Property(e => e.DepartureDatetime)
                .HasMaxLength(50)
                .HasColumnName("departure_datetime");
            entity.Property(e => e.DepartureIata)
                .HasMaxLength(50)
                .HasColumnName("departure_iata");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Note)
                .HasMaxLength(50)
                .HasColumnName("note");
            entity.Property(e => e.OffBlock)
                .HasMaxLength(50)
                .HasColumnName("off_block");
            entity.Property(e => e.OnBlock)
                .HasMaxLength(50)
                .HasColumnName("on_block");
            entity.Property(e => e.OwnerId).HasColumnName("owner_id");
        });

        modelBuilder.Entity<Idp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("idps_pkey");

            entity.ToTable("idps");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
        });

        modelBuilder.Entity<IdpOwner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("idp_owners_pkey");

            entity.ToTable("idp_owners");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdpId).HasColumnName("idp_id");
            entity.Property(e => e.OwnerId).HasColumnName("owner_id");
            entity.Property(e => e.Token)
                .HasColumnType("character varying")
                .HasColumnName("token");
        });

        modelBuilder.Entity<LoadWollenbergConstant>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("load_wollenberg_constants_pkey");

            entity.ToTable("load_wollenberg_constants");

            entity.HasIndex(e => e.Altitude, "index_load_wollenberg_constants_on_altitude");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.A).HasColumnName("a");
            entity.Property(e => e.Altitude).HasColumnName("altitude");
            entity.Property(e => e.B).HasColumnName("b");
            entity.Property(e => e.C).HasColumnName("c");
            entity.Property(e => e.D).HasColumnName("d");
        });

        modelBuilder.Entity<Logbook>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("logbook");

            entity.Property(e => e.FlightId).HasColumnName("flight_id");
            entity.Property(e => e.LoadId)
                .HasColumnType("character varying")
                .HasColumnName("load_id");
            entity.Property(e => e.OffBlock)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("off_block");
            entity.Property(e => e.OwnerId).HasColumnName("owner_id");
            entity.Property(e => e.RadiationAmount)
                .HasPrecision(10, 6)
                .HasColumnName("radiation_amount");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<Logbook2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("logbook2");

            entity.Property(e => e.FlightId).HasColumnName("flight_id");
            entity.Property(e => e.FlightRelationId).HasColumnName("flight_relation_id");
            entity.Property(e => e.LoadId)
                .HasColumnType("character varying")
                .HasColumnName("load_id");
            entity.Property(e => e.OffBlock)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("off_block");
            entity.Property(e => e.OwnerId).HasColumnName("owner_id");
            entity.Property(e => e.RadiationAmount)
                .HasPrecision(10, 6)
                .HasColumnName("radiation_amount");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<LoginAttempt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("login_attempts_pkey");

            entity.ToTable("login_attempts");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.PasswordStart)
                .HasColumnType("character varying")
                .HasColumnName("password_start");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<MailSubscription>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mail_subscriptions_pkey");

            entity.ToTable("mail_subscriptions");

            entity.HasIndex(e => e.MailType, "index_mail_subscriptions_on_mail_type");

            entity.HasIndex(e => e.UserId, "index_mail_subscriptions_on_user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.MailType).HasColumnName("mail_type");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.MailSubscriptions)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_rails_bba4ffe2f0");
        });

        modelBuilder.Entity<MeasuredRadiation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("measured_radiations_pkey");

            entity.ToTable("measured_radiations");

            entity.HasIndex(e => e.UtcTime, "index_measured_radiations_on_utc_time");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AvgCorr).HasColumnName("avg_corr");
            entity.Property(e => e.Corr1).HasColumnName("corr1");
            entity.Property(e => e.Corr2).HasColumnName("corr2");
            entity.Property(e => e.Corr3).HasColumnName("corr3");
            entity.Property(e => e.Corr4).HasColumnName("corr4");
            entity.Property(e => e.Corr5).HasColumnName("corr5");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UtcTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("utc_time");
        });

        modelBuilder.Entity<MeasurementLocation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("measurement_locations_pkey");

            entity.ToTable("measurement_locations");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address1)
                .HasColumnType("character varying")
                .HasColumnName("address1");
            entity.Property(e => e.Address2)
                .HasColumnType("character varying")
                .HasColumnName("address2");
            entity.Property(e => e.Address3)
                .HasColumnType("character varying")
                .HasColumnName("address3");
            entity.Property(e => e.Altitude).HasColumnName("altitude");
            entity.Property(e => e.LatestUtcDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("latest_utc_date");
            entity.Property(e => e.Latitude).HasColumnName("latitude");
            entity.Property(e => e.Longitude).HasColumnName("longitude");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.RadiationCoefficient).HasColumnName("radiation_coefficient");
            entity.Property(e => e.Website)
                .HasColumnType("character varying")
                .HasColumnName("website");
        });

        modelBuilder.Entity<Owner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("owners_pkey");

            entity.ToTable("owners");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.AirlineApiPostRadiation).HasColumnName("airline_api_post_radiation");
            entity.Property(e => e.AirlineApiUserIdentifier)
                .HasColumnType("character varying")
                .HasColumnName("airline_api_user_identifier");
            entity.Property(e => e.AirlineApiUserSecret)
                .HasColumnType("character varying")
                .HasColumnName("airline_api_user_secret");
            entity.Property(e => e.City)
                .HasColumnType("character varying")
                .HasColumnName("city");
            entity.Property(e => e.CountryId).HasColumnName("country_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CsvSeparators)
                .HasDefaultValue(0)
                .HasColumnName("csv_separators");
            entity.Property(e => e.DefaultUserEmail)
                .HasDefaultValueSql("''::character varying")
                .HasColumnType("character varying")
                .HasColumnName("default_user_email");
            entity.Property(e => e.EarlyBoundary).HasColumnName("early_boundary");
            entity.Property(e => e.EmailRecipients).HasColumnName("email_recipients");
            entity.Property(e => e.EntryDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("entry_date");
            entity.Property(e => e.FlightDataSource)
                .HasDefaultValueSql("'ftp'::character varying")
                .HasColumnType("character varying")
                .HasColumnName("flight_data_source");
            entity.Property(e => e.FtpPassword)
                .HasColumnType("character varying")
                .HasColumnName("ftp_password");
            entity.Property(e => e.FtpUsername)
                .HasColumnType("character varying")
                .HasColumnName("ftp_username");
            entity.Property(e => e.IcaoCode)
                .HasColumnType("character varying")
                .HasColumnName("icao_code");
            entity.Property(e => e.LockoutUsers).HasColumnName("lockout_users");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.OwnerTypeId).HasColumnName("owner_type_id");
            entity.Property(e => e.PostalCode)
                .HasColumnType("character varying")
                .HasColumnName("postal_code");
            entity.Property(e => e.Prefix)
                .HasColumnType("character varying")
                .HasColumnName("prefix");
            entity.Property(e => e.ProcessFlightAware)
                .HasDefaultValue(false)
                .HasColumnName("process_flight_aware");
            entity.Property(e => e.PublishRrtRad)
                .HasDefaultValue(false)
                .HasColumnName("publish_rrt_rad");
            entity.Property(e => e.SecretIdentifier)
                .HasColumnType("character varying")
                .HasColumnName("secret_identifier");
            entity.Property(e => e.SendDailyMails)
                .HasDefaultValue(false)
                .HasColumnName("send_daily_mails");
            entity.Property(e => e.StorageType)
                .HasDefaultValueSql("'ftp'::character varying")
                .HasColumnType("character varying")
                .HasColumnName("storage_type");
            entity.Property(e => e.StreetAddress1)
                .HasColumnType("character varying")
                .HasColumnName("street_address1");
            entity.Property(e => e.StreetAddress2)
                .HasColumnType("character varying")
                .HasColumnName("street_address2");
            entity.Property(e => e.ThresholdHigh).HasColumnName("threshold_high");
            entity.Property(e => e.ThresholdLow).HasColumnName("threshold_low");
            entity.Property(e => e.ThresholdPregnantHigh).HasColumnName("threshold_pregnant_high");
            entity.Property(e => e.ThresholdPregnantLow).HasColumnName("threshold_pregnant_low");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<OwnerType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("owner_types_pkey");

            entity.ToTable("owner_types");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<PostLaunchOldSystemFlight>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("post_launch_old_system_flights");

            entity.Property(e => e.AcReg)
                .HasMaxLength(200)
                .HasColumnName("ac_reg");
            entity.Property(e => e.AircraftId).HasColumnName("aircraft_id");
            entity.Property(e => e.AircraftModelId).HasColumnName("aircraft_model_id");
            entity.Property(e => e.AlternativeFlghts).HasColumnName("alternative_flghts");
            entity.Property(e => e.Concurrent)
                .HasDefaultValue(false)
                .HasColumnName("concurrent");
            entity.Property(e => e.Csv)
                .HasMaxLength(250)
                .HasColumnName("csv");
            entity.Property(e => e.DepartureCode)
                .HasMaxLength(30)
                .HasColumnName("departure_code");
            entity.Property(e => e.FlightName)
                .HasMaxLength(30)
                .HasColumnName("flight_name");
            entity.Property(e => e.FlightSeq).HasColumnName("flight_seq");
            entity.Property(e => e.MatchedFlight).HasColumnName("matched_flight");
            entity.Property(e => e.Message)
                .HasMaxLength(500)
                .HasColumnName("message");
            entity.Property(e => e.OffBlock)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("off_block");
            entity.Property(e => e.Radiation)
                .HasPrecision(10, 6)
                .HasColumnName("radiation");
        });

        modelBuilder.Entity<PreviousAircraftExperience>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("previous_aircraft_experiences_pkey");

            entity.ToTable("previous_aircraft_experiences");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AircraftType)
                .HasColumnType("character varying")
                .HasColumnName("aircraft_type");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Hours).HasColumnName("hours");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<PreviousEmployment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("previous_employments_pkey");

            entity.ToTable("previous_employments");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccumulatedAt).HasColumnName("accumulated_at");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.FoHours)
                .HasDefaultValueSql("0.0")
                .HasColumnName("fo_hours");
            entity.Property(e => e.IfrHours)
                .HasDefaultValueSql("0.0")
                .HasColumnName("ifr_hours");
            entity.Property(e => e.InstructorHours)
                .HasDefaultValueSql("0.0")
                .HasColumnName("instructor_hours");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.NightHours)
                .HasDefaultValueSql("0.0")
                .HasColumnName("night_hours");
            entity.Property(e => e.PicHours)
                .HasDefaultValueSql("0.0")
                .HasColumnName("pic_hours");
            entity.Property(e => e.SimulatorHours)
                .HasDefaultValueSql("0.0")
                .HasColumnName("simulator_hours");
            entity.Property(e => e.StudentHours)
                .HasDefaultValueSql("0.0")
                .HasColumnName("student_hours");
            entity.Property(e => e.TotalHours)
                .HasDefaultValueSql("0.0")
                .HasColumnName("total_hours");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<RadDiff>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("rad_diff");

            entity.Property(e => e.AcId).HasColumnName("ac_id");
            entity.Property(e => e.ArrIata)
                .HasColumnType("character varying")
                .HasColumnName("arr_iata");
            entity.Property(e => e.ArrPort)
                .HasColumnType("character varying")
                .HasColumnName("arr_port");
            entity.Property(e => e.Callsign)
                .HasColumnType("character varying")
                .HasColumnName("callsign");
            entity.Property(e => e.DepIata)
                .HasColumnType("character varying")
                .HasColumnName("dep_iata");
            entity.Property(e => e.DepPort)
                .HasColumnType("character varying")
                .HasColumnName("dep_port");
            entity.Property(e => e.GctRad).HasColumnName("gct_rad");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Manufacturer)
                .HasColumnType("character varying")
                .HasColumnName("manufacturer");
            entity.Property(e => e.Model)
                .HasColumnType("character varying")
                .HasColumnName("model");
            entity.Property(e => e.ModelId).HasColumnName("model_id");
            entity.Property(e => e.OffBlock)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("off_block");
            entity.Property(e => e.RadDiff1).HasColumnName("rad_diff");
            entity.Property(e => e.RadDiffPct).HasColumnName("rad_diff_pct");
            entity.Property(e => e.RealDiff).HasColumnName("real_diff");
            entity.Property(e => e.RegistrationCode)
                .HasColumnType("character varying")
                .HasColumnName("registration_code");
            entity.Property(e => e.RrtRad).HasColumnName("rrt_rad");
            entity.Property(e => e.TypeName)
                .HasColumnType("character varying")
                .HasColumnName("type_name");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("roles_pkey");

            entity.ToTable("roles");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Selectable).HasColumnName("selectable");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<SchemaMigration>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("schema_migrations");

            entity.HasIndex(e => e.Version, "unique_schema_migrations").IsUnique();

            entity.Property(e => e.Version)
                .HasColumnType("character varying")
                .HasColumnName("version");
        });

        modelBuilder.Entity<SecondaryRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("secondary_roles_pkey");

            entity.ToTable("secondary_roles");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<StukReportDreamjet2015>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("stuk_report_dreamjet_2015");

            entity.Property(e => e.AirHours).HasColumnName("Air hours");
            entity.Property(e => e.AircraftModel)
                .HasMaxLength(8)
                .IsFixedLength()
                .HasColumnName("Aircraft model");
            entity.Property(e => e.AirlineId)
                .HasMaxLength(5)
                .IsFixedLength()
                .HasColumnName("airline_id");
            entity.Property(e => e.Category).HasMaxLength(1);
            entity.Property(e => e.DosimeterReading)
                .HasMaxLength(8)
                .IsFixedLength()
                .HasColumnName("Dosimeter Reading");
            entity.Property(e => e.Effekt)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Empty1)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Empty 1");
            entity.Property(e => e.Empty2)
                .HasMaxLength(1)
                .HasColumnName("Empty 2");
            entity.Property(e => e.Empty4)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("Empty 4");
            entity.Property(e => e.Empty5)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("Empty 5");
            entity.Property(e => e.FirstWorkingDay)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("First Working Day");
            entity.Property(e => e.IntervalEnd)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Interval end");
            entity.Property(e => e.IntervalStart)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Interval start");
            entity.Property(e => e.LastWorkingDay)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Last Working Day");
            entity.Property(e => e.Method)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsFixedLength();
            entity.Property(e => e.Nationality)
                .HasMaxLength(15)
                .IsFixedLength();
            entity.Property(e => e.RadiationAmount).HasColumnName("radiation_amount");
            entity.Property(e => e.RadiationType)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("Radiation type");
            entity.Property(e => e.SocialSecNum)
                .HasMaxLength(16)
                .IsFixedLength()
                .HasColumnName("Social Sec Num");
        });

        modelBuilder.Entity<StukReportJettime2015>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("stuk_report_jettime_2015");

            entity.Property(e => e.AirHours).HasColumnName("Air hours");
            entity.Property(e => e.AircraftModel)
                .HasMaxLength(8)
                .IsFixedLength()
                .HasColumnName("Aircraft model");
            entity.Property(e => e.AirlineId)
                .HasMaxLength(5)
                .IsFixedLength()
                .HasColumnName("airline_id");
            entity.Property(e => e.Category).HasMaxLength(1);
            entity.Property(e => e.DosimeterReading)
                .HasMaxLength(8)
                .IsFixedLength()
                .HasColumnName("Dosimeter Reading");
            entity.Property(e => e.Effekt)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Empty1)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Empty 1");
            entity.Property(e => e.Empty2)
                .HasMaxLength(1)
                .HasColumnName("Empty 2");
            entity.Property(e => e.Empty4)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("Empty 4");
            entity.Property(e => e.Empty5)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("Empty 5");
            entity.Property(e => e.FirstWorkingDay)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("First Working Day");
            entity.Property(e => e.IntervalEnd)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Interval end");
            entity.Property(e => e.IntervalStart)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Interval start");
            entity.Property(e => e.LastWorkingDay)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Last Working Day");
            entity.Property(e => e.Method)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsFixedLength();
            entity.Property(e => e.Nationality)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.RadiationAmount).HasColumnName("radiation_amount");
            entity.Property(e => e.RadiationType)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("Radiation type");
            entity.Property(e => e.SocialSecNum)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("Social Sec Num");
        });

        modelBuilder.Entity<StukReportJettime2016>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("stuk_report_jettime_2016");

            entity.Property(e => e.AirHours).HasColumnName("Air hours");
            entity.Property(e => e.AircraftModel)
                .HasMaxLength(8)
                .IsFixedLength()
                .HasColumnName("Aircraft model");
            entity.Property(e => e.AirlineId)
                .HasMaxLength(5)
                .IsFixedLength()
                .HasColumnName("airline_id");
            entity.Property(e => e.Category).HasMaxLength(1);
            entity.Property(e => e.DosimeterReading)
                .HasMaxLength(8)
                .IsFixedLength()
                .HasColumnName("Dosimeter Reading");
            entity.Property(e => e.Effekt)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Empty1)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Empty 1");
            entity.Property(e => e.Empty2)
                .HasMaxLength(1)
                .HasColumnName("Empty 2");
            entity.Property(e => e.Empty4)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("Empty 4");
            entity.Property(e => e.Empty5)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("Empty 5");
            entity.Property(e => e.FirstWorkingDay)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("First Working Day");
            entity.Property(e => e.IntervalEnd)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Interval end");
            entity.Property(e => e.IntervalStart)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Interval start");
            entity.Property(e => e.LastWorkingDay)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Last Working Day");
            entity.Property(e => e.Method)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsFixedLength();
            entity.Property(e => e.Nationality)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.RadiationAmount).HasColumnName("radiation_amount");
            entity.Property(e => e.RadiationType)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("Radiation type");
            entity.Property(e => e.SocialSecNum)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("Social Sec Num");
        });

        modelBuilder.Entity<ThresholdExceedMailTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("threshold_exceed_mail_templates_pkey");

            entity.ToTable("threshold_exceed_mail_templates");

            entity.HasIndex(e => e.OwnerId, "index_threshold_exceed_mail_templates_on_owner_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AdminText).HasColumnName("admin_text");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.IsDefault).HasColumnName("is_default");
            entity.Property(e => e.NonpregnantText).HasColumnName("nonpregnant_text");
            entity.Property(e => e.OwnerId).HasColumnName("owner_id");
            entity.Property(e => e.PregnantText).HasColumnName("pregnant_text");
            entity.Property(e => e.SendToNonpregnant).HasColumnName("send_to_nonpregnant");
            entity.Property(e => e.SendToPregnant).HasColumnName("send_to_pregnant");
            entity.Property(e => e.ThresholdNonpregnant).HasColumnName("threshold_nonpregnant");
            entity.Property(e => e.ThresholdPregnant).HasColumnName("threshold_pregnant");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Owner).WithMany(p => p.ThresholdExceedMailTemplates)
                .HasForeignKey(d => d.OwnerId)
                .HasConstraintName("fk_rails_9778d7dddf");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("users_pkey");

            entity.ToTable("users");

            entity.HasIndex(e => e.AuthenticationToken, "index_users_on_authentication_token").IsUnique();

            entity.HasIndex(e => e.Email, "index_users_on_email");

            entity.HasIndex(e => e.LoadId, "index_users_on_load_id");

            entity.HasIndex(e => e.OwnerId, "index_users_on_owner_id");

            entity.HasIndex(e => e.ResetPasswordToken, "index_users_on_reset_password_token").IsUnique();

            entity.HasIndex(e => e.UnlockToken, "index_users_on_unlock_token").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address1)
                .HasColumnType("character varying")
                .HasColumnName("address1");
            entity.Property(e => e.Address2)
                .HasColumnType("character varying")
                .HasColumnName("address2");
            entity.Property(e => e.AuthenticationToken)
                .HasMaxLength(30)
                .HasColumnName("authentication_token");
            entity.Property(e => e.Base)
                .HasColumnType("character varying")
                .HasColumnName("base");
            entity.Property(e => e.CertificateNo)
                .HasColumnType("character varying")
                .HasColumnName("certificate_no");
            entity.Property(e => e.City)
                .HasColumnType("character varying")
                .HasColumnName("city");
            entity.Property(e => e.CountryId).HasColumnName("country_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CurrentSignInAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("current_sign_in_at");
            entity.Property(e => e.CurrentSignInIp).HasColumnName("current_sign_in_ip");
            entity.Property(e => e.DefaultRoleId).HasColumnName("default_role_id");
            entity.Property(e => e.Email)
                .HasDefaultValueSql("''::character varying")
                .HasColumnType("character varying")
                .HasColumnName("email");
            entity.Property(e => e.EmployeeNo)
                .HasColumnType("character varying")
                .HasColumnName("employee_no");
            entity.Property(e => e.EncryptedPassword)
                .HasDefaultValueSql("''::character varying")
                .HasColumnType("character varying")
                .HasColumnName("encrypted_password");
            entity.Property(e => e.FailedAttempts)
                .HasDefaultValue(0)
                .HasColumnName("failed_attempts");
            entity.Property(e => e.Gender)
                .HasColumnType("character varying")
                .HasColumnName("gender");
            entity.Property(e => e.HasCompletedFirstLogin)
                .HasDefaultValue(true)
                .HasColumnName("has_completed_first_login");
            entity.Property(e => e.Initials)
                .HasColumnType("character varying")
                .HasColumnName("initials");
            entity.Property(e => e.LastSignInAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_sign_in_at");
            entity.Property(e => e.LastSignInIp).HasColumnName("last_sign_in_ip");
            entity.Property(e => e.LatestFlightAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("latest_flight_at");
            entity.Property(e => e.LoadId)
                .HasColumnType("character varying")
                .HasColumnName("load_id");
            entity.Property(e => e.LockedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("locked_at");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Nationality)
                .HasColumnType("character varying")
                .HasColumnName("nationality");
            entity.Property(e => e.OldPassword)
                .HasColumnType("character varying")
                .HasColumnName("old_password");
            entity.Property(e => e.OwnerId).HasColumnName("owner_id");
            entity.Property(e => e.PhoneMobile)
                .HasColumnType("character varying")
                .HasColumnName("phone_mobile");
            entity.Property(e => e.PhoneOffice)
                .HasColumnType("character varying")
                .HasColumnName("phone_office");
            entity.Property(e => e.PregDeclaredAt).HasColumnName("preg_declared_at");
            entity.Property(e => e.PregGrounded).HasColumnName("preg_grounded");
            entity.Property(e => e.RadCalYear)
                .HasDefaultValueSql("0.0")
                .HasColumnName("rad_cal_year");
            entity.Property(e => e.RadFullYear)
                .HasDefaultValueSql("0.0")
                .HasColumnName("rad_full_year");
            entity.Property(e => e.RadPregnant)
                .HasDefaultValueSql("0.0")
                .HasColumnName("rad_pregnant");
            entity.Property(e => e.RadTotal)
                .HasDefaultValueSql("0.0")
                .HasColumnName("rad_total");
            entity.Property(e => e.RadUpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("rad_updated_at");
            entity.Property(e => e.RememberCreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("remember_created_at");
            entity.Property(e => e.ResetPasswordSentAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("reset_password_sent_at");
            entity.Property(e => e.ResetPasswordToken)
                .HasColumnType("character varying")
                .HasColumnName("reset_password_token");
            entity.Property(e => e.RolesMask).HasColumnName("roles_mask");
            entity.Property(e => e.SignInCount)
                .HasDefaultValue(0)
                .HasColumnName("sign_in_count");
            entity.Property(e => e.SocSecNo)
                .HasColumnType("character varying")
                .HasColumnName("soc_sec_no");
            entity.Property(e => e.SsoIdpId)
                .HasColumnType("character varying")
                .HasColumnName("sso_idp_id");
            entity.Property(e => e.SsoIdpIp)
                .HasColumnType("character varying")
                .HasColumnName("sso_idp_ip");
            entity.Property(e => e.SsoSignedInAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("sso_signed_in_at");
            entity.Property(e => e.SsoToken)
                .HasColumnType("character varying")
                .HasColumnName("sso_token");
            entity.Property(e => e.SsoTokenCreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("sso_token_created_at");
            entity.Property(e => e.State)
                .HasColumnType("character varying")
                .HasColumnName("state");
            entity.Property(e => e.UnlockToken)
                .HasColumnType("character varying")
                .HasColumnName("unlock_token");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.Username)
                .HasColumnType("character varying")
                .HasColumnName("username");
            entity.Property(e => e.Zip)
                .HasColumnType("character varying")
                .HasColumnName("zip");
        });

        modelBuilder.Entity<UserLink>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("user_links_pkey");

            entity.ToTable("user_links");

            entity.HasIndex(e => e.LinkedUserId, "index_user_links_on_linked_user_id");

            entity.HasIndex(e => e.UserId, "index_user_links_on_user_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.LinkedUserId).HasColumnName("linked_user_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<Version>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("versions_pkey");

            entity.ToTable("versions");

            entity.HasIndex(e => new { e.ItemType, e.ItemId }, "index_versions_on_item_type_and_item_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Event)
                .HasColumnType("character varying")
                .HasColumnName("event");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.ItemType)
                .HasColumnType("character varying")
                .HasColumnName("item_type");
            entity.Property(e => e.Object).HasColumnName("object");
            entity.Property(e => e.ObjectChanges).HasColumnName("object_changes");
            entity.Property(e => e.Whodunnit)
                .HasColumnType("character varying")
                .HasColumnName("whodunnit");
        });

        modelBuilder.Entity<VwAircraft>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_aircraft");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ManName)
                .HasColumnType("character varying")
                .HasColumnName("man_name");
            entity.Property(e => e.ModName)
                .HasColumnType("character varying")
                .HasColumnName("mod_name");
            entity.Property(e => e.RegistrationCode)
                .HasColumnType("character varying")
                .HasColumnName("registration_code");
        });

        modelBuilder.Entity<WideroeMissingCrewOperation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("wideroe_missing_crew_operations");

            entity.Property(e => e.AirportId).HasColumnName("airport_id");
            entity.Property(e => e.CrewFileName)
                .HasColumnType("character varying")
                .HasColumnName("crew_file_name");
            entity.Property(e => e.CrewLineContent)
                .HasColumnType("character varying")
                .HasColumnName("crew_line_content");
            entity.Property(e => e.CrewLineNumber).HasColumnName("crew_line_number");
            entity.Property(e => e.FfMtime).HasColumnName("ff_mtime");
            entity.Property(e => e.FlightFileName)
                .HasColumnType("character varying")
                .HasColumnName("flight_file_name");
            entity.Property(e => e.FlightId).HasColumnName("flight_id");
            entity.Property(e => e.FlightLineContent)
                .HasColumnType("character varying")
                .HasColumnName("flight_line_content");
            entity.Property(e => e.FlightLineNumber).HasColumnName("flight_line_number");
            entity.Property(e => e.FlightName)
                .HasColumnType("character varying")
                .HasColumnName("flight_name");
            entity.Property(e => e.FtpUsername)
                .HasColumnType("character varying")
                .HasColumnName("ftp_username");
            entity.Property(e => e.IataCode)
                .HasColumnType("character varying")
                .HasColumnName("iata_code");
            entity.Property(e => e.IcaoCode)
                .HasColumnType("character varying")
                .HasColumnName("icao_code");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LoadId)
                .HasColumnType("character varying")
                .HasColumnName("load_id");
            entity.Property(e => e.OffBlock).HasColumnName("off_block");
            entity.Property(e => e.OwnerId).HasColumnName("owner_id");
            entity.Property(e => e.RoleName)
                .HasColumnType("character varying")
                .HasColumnName("role_name");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<WorldRadiationCoefficient>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("world_radiation_coefficients_pkey");

            entity.ToTable("world_radiation_coefficients");

            entity.HasIndex(e => new { e.Altitude, e.Latitude, e.Longitude }, "index_world_radiation_coefficients_combined");

            entity.HasIndex(e => e.Altitude, "index_world_radiation_coefficients_on_altitude");

            entity.HasIndex(e => e.Latitude, "index_world_radiation_coefficients_on_latitude");

            entity.HasIndex(e => e.Longitude, "index_world_radiation_coefficients_on_longitude");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Altitude).HasColumnName("altitude");
            entity.Property(e => e.LastGenerationDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_generation_date");
            entity.Property(e => e.Latitude).HasColumnName("latitude");
            entity.Property(e => e.Longitude).HasColumnName("longitude");
            entity.Property(e => e.RadiationCoefficient).HasColumnName("radiation_coefficient");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
