using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace TestApp.Services.Interfaces
{
    public interface ICredentialsService : IService
    {
        public void GetCredentials();
        public void SetCredentials(string userName, string password);
        public void ClearCredentials();
        public void SetClientCredentials(HttpClient  client);
    }
}
