using AngularDashboardSPA.Common.DTOs.Auth;
using AngularDashboardSPA.Common.ServiceModels;
using AngularDashboardSPA.Common.Validators;
using AngularDashboardSPA.Service.Auth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace AngularDashboardSPA.Server.Controllers
{
    [Route("api/auth/")]
    [ApiController]
    [Authorize]
    public class AuthenticateController : ControllerBase
    {
        private IAuthService authService;

        public AuthenticateController(IAuthService authService)
        {
            this.authService = authService;
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("login")]
        [SwaggerResponse(200, Type = typeof(ServiceResponse<LoginResponseDTO>))]
        public async Task<IActionResult> Login(LoginDTO model)
        {
            try
            {
                var validator = new LoginValidators();
                var validationResult = validator.Validate(model);

                if (!validationResult.IsValid)
                {
                    return BadRequest(validationResult);
                }

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

        [HttpPost]
        [AllowAnonymous]
        [Route("register")]
        [SwaggerResponse(200, Type = typeof(ServiceResponse<RegisterDTO>))]
        public async Task<IActionResult> Register(RegisterDTO model)
        {
            try
            {
                var validator = new RegisterValidators();
                var validationResult = validator.Validate(model);

                if (!validationResult.IsValid)
                {
                    return BadRequest(validationResult);
                }

                var response = await authService.Register(model);

                if (!response.IsSuccess)
                {
                    return StatusCode(500, response);
                }

                return Ok(response);
            }
            catch (Exception) { throw; }
        }

        [HttpPost]
        [Route("create-admin")]
        public async Task<IActionResult> RegisterAdmin(CreateAdminDTO model)
        {
            try
            {
                var validator = new CreateAdminValidators();
                var validationResult = validator.Validate(model);

                if (!validationResult.IsValid)
                {
                    return BadRequest(validationResult);
                }

                var response = await authService.CreateAdmin(model);

                if (!response.IsSuccess)
                {
                    return BadRequest(response);
                }

                return Ok(response);
            }
            catch (Exception) { throw; }
        }
    }
}