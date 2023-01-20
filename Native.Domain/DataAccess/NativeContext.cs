using CsvHelper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
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
    public class NativeContext : DbContext
    {

        public NativeContext(DbContextOptions options)
            : base(options) 
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedInterests(modelBuilder);
            ConfigureProfileEventManyToManyRelationship(modelBuilder);
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder builder)
        {
            builder.Properties<TimeOnly>()
                .HaveConversion<TimeOnlyConverter>()
                .HaveColumnType("date");
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
                .Select((seedInterest) => new Interest() { Id = seedInterest.Id, Name = seedInterest.Name });

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

        public DbSet<Venue> Venues { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Location> Residences { get; set; }
        public DbSet<ProfileEvent> ProfileEvents { get; set; }

    }

    internal class TimeOnlyConverter : ValueConverter<TimeOnly, DateTime>
    {
        public TimeOnlyConverter() : base(
                d => DateTime.Today.Add(d.ToTimeSpan()),
                d => TimeOnly.FromDateTime(d)
            )
        {

        }
    }
}
