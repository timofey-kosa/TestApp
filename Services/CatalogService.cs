using Microsoft.AspNetCore.Server.Kestrel.Core.Features;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TestApp.Configuration;
using TestApp.Models;
using TestApp.Models.ErrorModel;
using System.Net;
using TestApp.Services.Interfaces;
using Microsoft.Extensions.Logging;

namespace TestApp.Services
{
    public class CatalogService : BaseService,ICatalogService
    {
        private readonly HttpClient _client;
        private readonly BaseUrlOptions _urlOptions;
        public CatalogService(HttpClient client,
            IOptions<BaseUrlOptions> urlOptions)
        {
            _client = client;
            _urlOptions = urlOptions.Value;

            _client.BaseAddress = new Uri(_urlOptions.BaseUrl);
            base.SetClientCredentials(_client);

        }

        public async Task<List<ProductForView>> GetCatalogAsync()
        {
            
            string urlCatalog = "integration/v1.0/catalog";
            var response = await _client.GetAsync(urlCatalog);
            var responseContent = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            { 
                var brandDict = JsonConvert.DeserializeObject<IDictionary<string, IEnumerable<Brand>>>(responseContent);
                var brandList = brandDict["brands"];
                var catalog = new List<ProductForView>();

                foreach (var brand in brandList)
                {
                    foreach (var product in brand.Products)
                    {
                        ProductForView productCreate = new ProductForView()
                        {
                            Name = product.Name,
                            Id = product.Id,
                            Brand = brand,
                            MinFaceValue = product.MinFaceValue,
                            MaxFaceValue = product.MaxFaceValue,
                            ModifiedDate = product.ModifiedDate

                        };
                        catalog.Add(productCreate);
                    }
                }

                return catalog;
            }
            else if(response.StatusCode == HttpStatusCode.Unauthorized)
            {
                throw new UnauthorizedAccessException();
            }

            else if (response.StatusCode == HttpStatusCode.BadRequest )
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
