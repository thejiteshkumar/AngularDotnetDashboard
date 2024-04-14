using AngularDashboardSPA.Common.DTOs.Auth;
using AngularDashboardSPA.Common.ServiceModels;
using AngularDashboardSPA.DAL.Models.Auth;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

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

        public async Task<ServiceResponse<LoginResponseDTO>> Login(LoginDTO model)
        {
            var response = new ServiceResponse<LoginResponseDTO>();

            var user = await userManager.FindByEmailAsync(model.Email);
            if (user != null && await userManager.CheckPasswordAsync(user, model.Password))
            {
                var userRoles = await userManager.GetRolesAsync(user);
                var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                };

                foreach (var userRole in userRoles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, userRole));
                }

                var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"]));

                var token = new JwtSecurityToken(
                    issuer: configuration["JWT:ValidIssuer"],
                    audience: configuration["JWT:ValidAudience"],
                    expires: DateTime.Now.AddHours(3),
                    claims: authClaims,
                    signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                    );

                response.Data = new LoginResponseDTO
                {
                    Email = user.Email,
                    Token = new JwtSecurityTokenHandler().WriteToken(token),
                    Expiration = token.ValidTo.ToString()
                };
            }
            else
            {
                response.ErrorMessage = "User not found or invalid credentials.";
            }

            return response;
        }

        public async Task<ServiceResponse<RegisterDTO>> Register(RegisterDTO model)
        {
            var response = new ServiceResponse<RegisterDTO>();
            var userExists = await userManager.FindByEmailAsync(model.Username);

            if (userExists != null)
            {
                response.ErrorMessage = "User already exists!";
                return response;
            }

            User user = new User()
            {
                Email = model.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = model.Username
            };
            var result = await userManager.CreateAsync(user, model.Password);

            if (!result.Succeeded)
            {
                response.ErrorMessage = "User creation failed! Please check user details and try again.";
            }

            return response;
        }

        public async Task<ServiceResponse<object>> CreateAdmin(CreateAdminDTO model)
        {
            var response = new ServiceResponse<object>();

            var user = await userManager.FindByEmailAsync(model.Email);

            if (user == null)
            {
                response.ErrorMessage = "Admin privileges can only be assigned to existing users.";
                return response;
            }

            if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));

            if (!await roleManager.RoleExistsAsync(UserRoles.User))
                await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

            var result = await userManager.AddToRoleAsync(user, UserRoles.Admin);

            if (result.Succeeded)
            {
                response.Data = new
                {
                    Message = $"User {user.Email} promoted to Admin"
                };
            }

            return response;
        }
    }
}