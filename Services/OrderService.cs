using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TestApp.Configuration;
using TestApp.Models;
using TestApp.Models.Cart;
using TestApp.Models.ErrorModel;
using TestApp.Models.OrderModels;
using TestApp.Services.Interfaces;

namespace TestApp.Services
{
    public class OrderService : BaseService,IOrderService
    {
        private readonly HttpClient _client;
        private readonly BaseUrlOptions _urlOptions;
        private readonly IAccountService _accountService;

        public OrderService(HttpClient client,            
            IOptions<BaseUrlOptions> urlOptions,
            IAccountService accountService
            )
        {
            _client = client;
            _accountService = accountService;
            base.SetClientCredentials(_client);
            _urlOptions = urlOptions.Value;
            _client.BaseAddress = new Uri(_urlOptions.BaseUrl);

        }
        public async Task<IEnumerable<OrderResponse>> GetOrderHistoryAsync()
        {
            var url = "integration/v1.0/orders/history";
            var response = await _client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode) 
            {               
                var orderResponseList = JsonConvert.DeserializeObject<IEnumerable<OrderResponse>>(content);
                return orderResponseList;
            }
            else if(response.StatusCode==System.Net.HttpStatusCode.Unauthorized)
            {
                throw new UnauthorizedAccessException();
            }
            else 
            {
                throw new ResponseException("Ploho",content);
            }
        }

        public async Task<OrderResponse> SubmitOrderAsync()
        {
            try { 
                List<OrderProduct> productToOrderList = new List<OrderProduct>();

                foreach (var product in Cart.CartList)
                {
                    var productToAdd = new OrderProduct()
                    {
                        ProductId = product.ProductId,
                        Quantity = product.Qauntity,
                        Value = product.Value
                    };
                    productToOrderList.Add(productToAdd);
                }

                string url = "integration/v1.0/orders/checkout";
                var account = await _accountService.GetAccountAsync();

                var orderRequest = new CreateOrderRequest()
                {
                    RequestId = Guid.NewGuid(),
                    Products = productToOrderList,
                    AccountId = account.Id
                };

                var dataToSend = JsonConvert.SerializeObject(orderRequest);
                var httpContent = new StringContent(dataToSend, Encoding.UTF8, "application/json");
                var response = await _client.PostAsync(url, httpContent);
                var content = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    var orderResponse = JsonConvert.DeserializeObject<OrderResponse>(content);
                    Cart.CartList.Clear();
                    return orderResponse;
                }
                else
                {
                    var message = JsonConvert.DeserializeObject<ErrorModel>(content);

                    throw new ResponseException(message.Message,"");
                }


                
            }
            catch (UnauthorizedAccessException)
            {
                throw new UnauthorizedAccessException();
            }

         }


    }

    }

