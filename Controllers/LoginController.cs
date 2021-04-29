using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestApp.Services;
using TestApp.Services.Interfaces;

namespace TestApp.Controllers
{
    public class LoginController : Controller
    {
        private readonly ICredentialsService _credentialsService;

        public LoginController(ICredentialsService credentialsService)
        {           
            _credentialsService = credentialsService;
        }
        [HttpPost]
        public IActionResult LogIn(string login , string password )
        {          
            _credentialsService.SetCredentials(login, password);
      
            return Redirect("/Home/GetCatalog");
        }

        public IActionResult LogOut()
        {
           
            _credentialsService.ClearCredentials();
            return Redirect("/Home/Index");
        }
    }
}
