using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Native.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Services.DataAccess
{
    public class NativeContext : DbContext
    {

        public NativeContext(DbContextOptions options)
            : base(options) 
        {

        }

        protected override void ConfigureConventions(ModelConfigurationBuilder builder)
        {
            builder.Properties<TimeOnly>()
                .HaveConversion<TimeOnlyConverter>()
                .HaveColumnType("date");
        }

        public DbSet<Venue> Venues { get; set; }
        public DbSet<Interest> Interests { get; set; }

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
