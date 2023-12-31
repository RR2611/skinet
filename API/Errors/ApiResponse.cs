using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDeaultMessageForStatusCode(statusCode);
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }

        private string GetDeaultMessageForStatusCode(int statusCode)
        {
           return statusCode switch
           {
                400 => "A bad request you have made",
                401 => "Authorised you are not",
                404 => "Resource found - ti was not",
                500 => "Errors are the path to the dark side",
                _ => null
           };
        }
    }
}