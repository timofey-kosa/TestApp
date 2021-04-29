using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Models.ErrorModel
{
    public class ErrorModel
    {
        public string Message { get; set; }
        public List<string> ErrorMessages { get; set; } = new List<string>();

    }
}
