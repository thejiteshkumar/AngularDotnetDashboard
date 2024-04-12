using AngularDashboardSPA.Common.DTOs.Auth;
using AngularDashboardSPA.DAL.Models.Auth;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace AngularDashboardSPA.Service.Auth
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<User> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IConfiguration configuration;

        public AuthService(
            UserManager<User> userManager,
            RoleManager<IdentityRole> roleManager,
            IConfiguration configuration
        )
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.configuration = configuration;
        }

        public Task<LoginDTO> Login()
        {
            throw new NotImplementedException();
        }

        public Task<RegisterDTO> Register()
        {
            throw new NotImplementedException();
        }
    }
}
