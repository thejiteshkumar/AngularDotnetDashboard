using AngularDashboardSPA.Common.DTOs.Auth;
using AngularDashboardSPA.Common.ServiceModels;
using AngularDashboardSPA.Service.Auth;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace AngularDashboardSPA.Server.Controllers
{
    [Route("api/auth/")]
    [ApiController]
    public class AuthenticateController : ControllerBase
    {
        private IAuthService authService;

        public AuthenticateController(IAuthService authService)
        {
            this.authService = authService;
        }

        [HttpPost]
        [Route("login")]
        [SwaggerResponse(200, Type = typeof(ServiceResponse<LoginResponseDTO>))]

        public async Task<IActionResult> Login(LoginDTO model)
        {
            try
            {
                //Add Fluent validations.
                var response = await authService.Login(model);

                if (!response.IsSuccess)
                {
                    return BadRequest(response);
                }

                return Ok(response);
            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}
