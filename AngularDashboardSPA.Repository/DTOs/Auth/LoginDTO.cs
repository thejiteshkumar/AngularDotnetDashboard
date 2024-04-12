namespace AngularDashboardSPA.Common.DTOs.Auth
{
    public record LoginDTO
    {
        public string? Email { get; set; }
        public string? Token { get; set; }
    }
}
