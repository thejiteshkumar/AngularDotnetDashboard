namespace AngularDashboardSPA.Common.DTOs.Auth
{
    public record LoginDTO
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
    }

    public class LoginResponseDTO
    {
        public string? Email { get; set; }
        public string? Token { get; set; }
        public string? Expiration { get; set; }
    }
}