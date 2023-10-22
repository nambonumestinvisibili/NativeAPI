using CsvHelper;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Native.Domain.Configuration;
using Native.Domain.Models;
using Native.Domain.Seed;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Native.Domain.DataAccess
{
    public class NativeContext : IdentityDbContext<User>
    {

        public NativeContext(DbContextOptions options)
            : base(options) 
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //todo: if env
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new RoleConfiguration());

            SeedInterests(modelBuilder);
            
            ConfigureProfileEventManyToManyRelationship(modelBuilder);
            ConfigureProfileVenueManyToManyRelationship(modelBuilder);
            ConfigureProfileCityManyToManyRelationship(modelBuilder);
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder builder)
        {
            builder.Properties<TimeOnly>()
                .HaveConversion<TimeOnlyConverter>()
                .HaveColumnType("time");
        }
        
        private static void SeedInterests(ModelBuilder modelBuilder)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            string resourceName = "Native.Domain.Seed.Interests.csv";
            using Stream stream = assembly.GetManifestResourceStream(resourceName)!;
            using StreamReader reader = new(stream, Encoding.UTF8);
            
            CsvReader csvReader = new(reader, System.Globalization.CultureInfo.CurrentCulture);

            var interests = csvReader.GetRecords<InterestSeed>()
                .ToImmutableList()
                .Select((seedInterest) => new Interest() { Id = seedInterest.Id, Guid = seedInterest.Guid, Name = seedInterest.Name });

            modelBuilder.Entity<Interest>().HasData(interests);
        }

        private static void ConfigureProfileEventManyToManyRelationship(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProfileEvent>()
                .HasKey(profileEvent => new { profileEvent.ProfileId, profileEvent.EventId });
            modelBuilder.Entity<ProfileEvent>()
                .HasOne(pe => pe.Profile)
                .WithMany(p => p.ProfileEvents)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<ProfileEvent>()
                .HasOne(pe => pe.Event)
                .WithMany(e => e.InvitedGuests)
                .OnDelete(DeleteBehavior.NoAction);
        }

        private static void ConfigureProfileVenueManyToManyRelationship(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProfileVenue>()
                .HasKey(profileVenue => new { profileVenue.ProfileId, profileVenue.VenueId });
            modelBuilder.Entity<ProfileVenue>()
                .HasOne(pv => pv.Profile)
                .WithMany(p => p.VisitedVenues)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<ProfileVenue>()
                .HasOne(pv => pv.Venue)
                .WithMany(v => v.ProfilesThatVisitedVenue)
                .OnDelete(DeleteBehavior.NoAction);
        }

        private static void ConfigureProfileCityManyToManyRelationship(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProfileCity>()
                .HasKey(profileVenue => new { profileVenue.ProfileId, profileVenue.CityId });
            modelBuilder.Entity<ProfileCity>()
                .HasOne(pc => pc.Profile)
                .WithMany(p => p.CitiesThatTheProfileVisited)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<ProfileCity>()
                .HasOne(pc => pc.City)
                .WithMany(c => c.ProfilesWhichVisitedTheCity)
                .OnDelete(DeleteBehavior.NoAction);
        }

        public DbSet<Venue> Venues { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Location> Residences { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<ProfileEvent> ProfileEvents { get; set; }
        public DbSet<ProfileVenue> ProfileVenues { get; set; }
        public DbSet<ProfileCity> ProfileCity { get; set; }


    }

    internal class TimeOnlyConverter : ValueConverter<TimeOnly, TimeSpan>
    {
        public TimeOnlyConverter() : base(timeOnly =>
                timeOnly.ToTimeSpan(),
            timeSpan => TimeOnly.FromTimeSpan(timeSpan))
        { }
    }
}
