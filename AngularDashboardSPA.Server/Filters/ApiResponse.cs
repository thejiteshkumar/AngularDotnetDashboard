namespace AngularDashboardSPA.Server.Filters
{
    public class ApiResponse<T>
    {
        public string? Status { get; set; }
        public int StatusCode { get; set; }
        public T? Data { get; set; }
    }
}