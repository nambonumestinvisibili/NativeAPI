﻿using Microsoft.Extensions.DependencyInjection;
using Native.Service.Services;
using Native.Service.Services.Interfaces;

namespace Native.Service
{
    public static class Extensions
    {
        public static void ConfigureNativeServices(this IServiceCollection services)
        {
            services.AddScoped<IVenueService, VenueService>();
        }

    }
}