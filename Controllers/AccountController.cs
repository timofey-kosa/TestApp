using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestApp.Models.ErrorModel;
using TestApp.Services;

namespace TestApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        public async Task<IActionResult> GetAccount()
        {
            try
            {
                var account = await _accountService.GetAccountAsync();
                return View(account);
            }
            catch (UnauthorizedAccessException)
            { 
                return Redirect("/Home/Index"); 
            }
            catch (ResponseException ex)
            {
                return View("ErrorView", ex);
            }


        }
    }
}
