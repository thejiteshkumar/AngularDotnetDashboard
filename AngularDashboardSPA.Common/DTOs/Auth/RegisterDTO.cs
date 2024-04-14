using System.ComponentModel.DataAnnotations;

namespace AngularDashboardSPA.Common.DTOs.Auth
{
    public record RegisterDTO
    {
        [Required]
        public string? Username { get; set; }

        [Required]
        public string? Email { get; set; }

        [Required]
        public string? Password { get; set; }
    }
}
