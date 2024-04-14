using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AngularDashboardSPA.Server.Filters
{
    public class ApiResponseFilters : IActionFilter, IExceptionFilter
    {
        private ILogger logger;

        public ApiResponseFilters(ILogger<ApiResponseFilters> logger)
        {
            this.logger = logger;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.Result is ObjectResult objectResult)
            {
                var apiResponse = new ApiResponse<object>
                {
                    StatusCode = objectResult.StatusCode ?? StatusCodes.Status200OK,
                    Data = objectResult.Value
                };

                if (IsErrorStatusCode(apiResponse.StatusCode))
                {
                    apiResponse.Status = "Error";
                }
                else
                {
                    apiResponse.Status = "Success";
                }

                context.Result = new ObjectResult(apiResponse)
                {
                    StatusCode = apiResponse.StatusCode
                };

            }
            else if (context.Result is StatusCodeResult statusCodeResult)
            {
                var apiResponse = new ApiResponse<object>
                {
                    Status = "Success",
                    StatusCode = statusCodeResult.StatusCode
                };

                context.Result = new ObjectResult(apiResponse)
                {
                    StatusCode = apiResponse.StatusCode
                };
            }
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            //Runs before any action method is executed
        }

        public void OnException(ExceptionContext context)
        {
            // Log the exception
            logger.LogError($"{context.Exception}");

            var apiResponse = new ApiResponse<object>
            {
                Status = "Error",
                StatusCode = StatusCodes.Status500InternalServerError,
                Data = new { ErrorMessage = context.Exception.Message }
            };

            context.Result = new ObjectResult(apiResponse)
            {
                StatusCode = StatusCodes.Status500InternalServerError
            };

            //NOTE : Marking the exception as handled, 
            context.ExceptionHandled = true;
        }


        private bool IsErrorStatusCode(int statusCode)
        {
            // Any status code 400 or above is considered an error
            return statusCode >= 400;
        }
    }
}
