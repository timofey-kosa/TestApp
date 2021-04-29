using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApp.Models;
using TestApp.Services.Interfaces;

namespace TestApp.Services
{
    public interface ICatalogService : IService
    {
        public Task<List<ProductForView>> GetCatalogAsync();
    }
}
