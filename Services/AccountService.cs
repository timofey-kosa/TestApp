
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TestApp.Configuration;
using TestApp.Models;
using TestApp.Models.ErrorModel;
using TestApp.Models.LoginModel;
using TestApp.Services.Interfaces;

namespace TestApp.Services
{
    public class AccountService : BaseService,IAccountService
    {
        private readonly HttpClient _client;
        private readonly ICredentialsService _credentialsService;
        private readonly BaseUrlOptions _urlOptions;

        public  AccountService(
            ICredentialsService credentialsService,
            IOptions<BaseUrlOptions> urlOptions,
            HttpClient client
           ) 
        {
            _client = client;
            _credentialsService = credentialsService;
            _urlOptions = urlOptions.Value;

            _client.BaseAddress = new Uri(_urlOptions.BaseUrl);
            
        }

        public  async Task<Account> GetAccountAsync()
        {
            base.SetClientCredentials(_client);
            string url = "integration/v1.0/accounts";
            
            var response = await _client.GetAsync(url);
            var responseContent = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                Account account = JsonConvert.DeserializeObject<AccountResponse>(responseContent).Accounts.First();
                return account;
            }

            else if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                throw new UnauthorizedAccessException();
            }

            else if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                throw new ResponseException("Bad Request. Chto-to s serverom",responseContent);
            }
            else
            {
                throw new ResponseException("Voobshe hz",responseContent);

            }




        }

    }
}
