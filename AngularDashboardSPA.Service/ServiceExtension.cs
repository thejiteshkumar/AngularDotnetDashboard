using AngularDashboardSPA.Service.Auth;
using Microsoft.Extensions.DependencyInjection;

namespace AngularDashboardSPA.Service
{
    public static class ServiceExtension
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddTransient<IAuthService, AuthService>();
        }

    }
}
