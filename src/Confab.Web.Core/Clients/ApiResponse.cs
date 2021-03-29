using System.Net.Http;

namespace Confab.Web.Core.Clients
{
    public class ApiResponse
    {
        public HttpResponseMessage HttpResponse { get; }
        public bool Succeeded { get; }
        public ErrorsResponse Errors { get; }

        public ApiResponse(HttpResponseMessage httpResponse, bool succeeded, ErrorsResponse errors = null)
        {
            HttpResponse = httpResponse;
            Succeeded = succeeded;
            Errors = errors;
        }

        public class ErrorsResponse
        {
            public ErrorResponse[] Errors { get; set; }
        }

        public class ErrorResponse
        {
            public string Code { get; set; }
            public string Message { get; set; }
        }
    }

    public class ApiResponse<T> : ApiResponse
    {
        public T Value { get; }

        public ApiResponse(T value, HttpResponseMessage httpResponse, bool succeeded, ErrorsResponse errors = null)
            : base(httpResponse, succeeded, errors)
        {
            Value = value;
        }
    }
}