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
    public class CredentialsService : BaseService,ICredentialsService
    {
        public void ClearCredentials()
        {
            Credentials.Name="";
            Credentials.Secret = "";
        }

        public void GetCredentials()
        {
            throw new NotImplementedException();
        }

        public void SetCredentials(string userName, string password)
        {
            Credentials.Name = userName;
            Credentials.Secret = password;
        }

    }
}
