using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.DependencyInjection;
using System.Text.Json.Serialization;

namespace Native.API
{
    public static class Extensions
    {
        public static void ConfigureControllers(this IServiceCollection services) =>
            services.AddControllers()
            .AddJsonOptions(opts =>
            {
                opts.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
                opts.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
            })
            .PartManager.ApplicationParts.Add(new AssemblyPart(typeof(Extensions).Assembly));
    }
}