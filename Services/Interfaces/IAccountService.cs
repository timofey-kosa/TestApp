using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApp.Models;
using TestApp.Services.Interfaces;

namespace TestApp.Services
{
    public interface IAccountService : IService
    {
        public  Task<Account>  GetAccountAsync();
    }
}
