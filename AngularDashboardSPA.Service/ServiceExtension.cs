using AngularDashboardSPA.Common.DTOs.Auth;
using AngularDashboardSPA.Common.Validators;
using AngularDashboardSPA.Service.Auth;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace AngularDashboardSPA.Service
{
    public static class ServiceExtension
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddTransient<IAuthService, AuthService>();
        }

        public static void AddValidators(this IServiceCollection services)
        {
            services.AddTransient<IValidator<LoginDTO>, LoginValidators>();
            services.AddTransient<IValidator<RegisterDTO>, RegisterValidators>();
            services.AddTransient<IValidator<CreateAdminDTO>, CreateAdminValidators>();
        }
    }
}