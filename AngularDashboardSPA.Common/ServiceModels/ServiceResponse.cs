namespace AngularDashboardSPA.Common.ServiceModels
{
    public class ServiceResponse<T>
    {
        public T? Data { get; set; }
        public string? ErrorMessage { get; set; }
        public bool IsSuccess => string.IsNullOrEmpty(ErrorMessage);
    }
}