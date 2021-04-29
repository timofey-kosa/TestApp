using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApp.Models;
using TestApp.Models.OrderModels;

namespace TestApp.Services.Interfaces
{
    public interface IOrderService : IService
    {
        public Task<IEnumerable<OrderResponse>> GetOrderHistoryAsync();
        public Task<OrderResponse> SubmitOrderAsync();
    }
}
