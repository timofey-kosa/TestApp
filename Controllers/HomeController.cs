using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestApp.Models;
using TestApp.Services;
using TestApp.Models.Cart;
using TestApp.Models.ErrorModel;

namespace TestApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICatalogService _catalogService;

        public HomeController(ICatalogService catalogService)
        {
            _catalogService = catalogService;
        }
        
        //HomePage,Error
        #region


        public async Task<IActionResult> Index()
        {

            return View();
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        #endregion

        public async Task<IActionResult> GetCatalog()
        {
            try
            {
                var catalog = await _catalogService.GetCatalogAsync();
                return View(catalog);
            }
            catch (UnauthorizedAccessException)
            {
                return Redirect("/Home/Index");
            }
            catch (ResponseException ex)
            {
                return View("ErrorView",ex);
            }
        }

        [HttpPost]
        public async void AddToCart([FromBody] ProductForCart request)
        {
            try {
                ProductForCart order = new ProductForCart()
                { ProductId = request.ProductId,
                    Value = request.Value,
                    Qauntity = 1,

                };
                var productsFromCatalog = await _catalogService.GetCatalogAsync();

                var product = productsFromCatalog.Find(p => p.Id == order.ProductId);
                order.BrandName = product.Brand.Name;
                order.Currency = product.Brand.CurrencyCode;
                if (product.MinFaceValue == product.MaxFaceValue)
                {
                    order.Denomination = product.MaxFaceValue.ToString();
                }
                else
                {
                    order.Denomination = product.MinFaceValue + "-" + product.MaxFaceValue;
                }

                if (Cart.CartList.Count == 0)
                {
                    Cart.CartList.Add(order);
                }
                else
                {
                    if (Cart.CartList.Find(el => el.ProductId == order.ProductId && el.Value == order.Value) != null)
                    {
                        Cart.CartList.Find(el => el.ProductId == order.ProductId && el.Value == order.Value).Qauntity++;
                    }
                    else
                    {
                        Cart.CartList.Add(order);
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                RedirectToAction("Index");
            }
        }
       
    }
}
