using AngularDashboardSPA.Common.DTOs.Auth;

namespace AngularDashboardSPA.Service.Auth
{
    public interface IAuthService
    {
        Task<LoginDTO> Login();
        Task<RegisterDTO> Register();
    }
}
