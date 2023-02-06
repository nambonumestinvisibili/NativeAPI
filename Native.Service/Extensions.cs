using Microsoft.Extensions.DependencyInjection;
using Native.Service.Services;
using Native.Service.Services.Interfaces;

namespace Native.Service
{
    public static class Extensions
    {
        public static void ConfigureNativeServices(this IServiceCollection services)
        {
            services.AddScoped<IVenueService, VenueService>();
            services.AddScoped<IInterestService, InterestService>();
            services.AddScoped<IProfileService, ProfileService>();
            services.AddScoped<IEventService, EventService>();
            services.AddScoped<IResidenceService, ResidenceService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<TokenService>();

#if DEBUG
            services.AddScoped<IFakeUserService, FakeUserService>();
#endif
        }

    }
}