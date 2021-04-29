using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Models.ErrorModel
{
    public class ResponseException: Exception
    {
        public readonly string ExceptionMessage;
        public readonly string ResponseMessage;
        public ResponseException(string message,string responseMessage)
        {
            ExceptionMessage= message;
            ResponseMessage = responseMessage;
        }
    }
}
