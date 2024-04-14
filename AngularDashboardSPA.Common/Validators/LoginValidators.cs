using AngularDashboardSPA.Common.DTOs.Auth;
using FluentValidation;

namespace AngularDashboardSPA.Common.Validators
{
    public class LoginValidators : AbstractValidator<LoginDTO>
    {
        public LoginValidators()
        {
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.Password).NotEmpty();
        }
    }

    public class RegisterValidators : AbstractValidator<RegisterDTO>
    {
        public RegisterValidators()
        {
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.Username).NotEmpty();
            RuleFor(x => x.Password)
                .NotEmpty()
                .MinimumLength(4)
                .MaximumLength(15);
        }
    }

    public class CreateAdminValidators : AbstractValidator<CreateAdminDTO>
    {
        public CreateAdminValidators()
        {
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
        }
    }
}