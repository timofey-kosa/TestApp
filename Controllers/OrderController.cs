using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestApp.Models.Cart;
using TestApp.Models.ErrorModel;
using TestApp.Services.Interfaces;

namespace TestApp.Controllers
{
    public class OrderController : Controller
    { 
        private readonly IOrderService _orderService;
       
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public IActionResult GetCart()
        {      
            return View(Cart.CartList);
        }

        public async Task<IActionResult> SubmitOrder() 
        {
            try 
            { 
                var orderList = await _orderService.SubmitOrderAsync();
                return View(orderList);
            }
            catch(UnauthorizedAccessException)
            {
                return RedirectToAction("Index", "Home");
            }
            catch (ResponseException ex)
            {
                ViewBag.Message = ex.ExceptionMessage;
                return View();
            }
        }

        public async Task<IActionResult> GetOrderHistory() 
        {
            try 
            { 
                var orderHistory = await _orderService.GetOrderHistoryAsync();
                return View(orderHistory);
            }
            catch (UnauthorizedAccessException) 
            {
                return RedirectToAction("Index", "Home");                
            }
            catch(ResponseException ex)
            {
                return View("ErrorView", ex);
            }
        }



    }
}
