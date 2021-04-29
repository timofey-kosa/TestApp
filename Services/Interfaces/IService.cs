using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace TestApp.Services.Interfaces
{
    public interface IService
    {
        public void SetClientCredentials(HttpClient client);
    }
}
