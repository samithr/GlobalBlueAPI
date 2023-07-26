using GlobalBlueTest.Service;

namespace GlobalBlueTest.Service.Shared
{
    public class ServiceResponse
    {
        public ApiResponseCodes StatusCode { get; set; }
        public bool IsError { get; set; }
        public string Message { get; set; }
        public object Result { get; set; }

        public ServiceResponse(ApiResponseCodes statuscode, bool isError, string message, object result)
        {
            StatusCode = statuscode;
            IsError = isError;
            Message = message;
            Result = result;
        }
    }
}
