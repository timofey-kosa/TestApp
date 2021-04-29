using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TestApp.Models.LoginModel;
using TestApp.Services.Interfaces;

namespace TestApp.Services
{
    public class BaseService : IService
    {
        public void SetClientCredentials(HttpClient client)
        {
            var byteArray = Encoding.ASCII.GetBytes($"{Credentials.Name}:{Credentials.Secret}");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
        }
    }
}
