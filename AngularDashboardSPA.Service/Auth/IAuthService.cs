using AngularDashboardSPA.Common.DTOs.Auth;
using AngularDashboardSPA.Common.ServiceModels;

namespace AngularDashboardSPA.Service.Auth
{
    public interface IAuthService
    {
        Task<ServiceResponse<LoginResponseDTO>> Login(LoginDTO login);

        Task<ServiceResponse<RegisterDTO>> Register(RegisterDTO model);

        Task<ServiceResponse<object>> CreateAdmin(CreateAdminDTO model);
    }
}