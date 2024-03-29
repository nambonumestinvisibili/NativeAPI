﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Native.Domain.Models;
using Native.Domain.DataAccess;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.AspNetCore.Http;

namespace Native.Domain
{
    public static class Extensions
    {

        public static void ConfigureDbContext(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<NativeContext>(
                opts => opts.UseSqlServer(connectionString, 
                    b => b.MigrationsAssembly(GetAssemblyName())));
        }

        public static void ConfigureIdentity(this IServiceCollection services)
        {
            var builder = services.AddIdentityCore<User>(opts =>
            {
                opts.User.RequireUniqueEmail = true;
            });

            builder = new IdentityBuilder(builder.UserType, typeof(IdentityRole),
                builder.Services);
            builder
                .AddEntityFrameworkStores<NativeContext>()
                .AddDefaultTokenProviders();

            services.TryAddScoped<SignInManager<User>>();
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();


        }

        private static string GetAssemblyName() => typeof(Venue).Assembly.GetName().Name!;
    }
}