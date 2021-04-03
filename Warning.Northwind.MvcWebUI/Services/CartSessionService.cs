using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warning.Northwind.Entities.Concrete;
using Warning.Northwind.MvcWebUI.ExtensionMethods;

namespace Warning.Northwind.MvcWebUI.Services
{
    public class CartSessionService : ICartSessionService
    {
       
      
            private IHttpContextAccessor _httpContextAccessor;

            public CartSessionService(IHttpContextAccessor httpContextAccessor)
            {
                _httpContextAccessor = httpContextAccessor;
            }

            public Cart GetCart()
            {
                Cart cartToCheck = _httpContextAccessor.HttpContext.Session.GetObject<Cart>("cart");
                if (cartToCheck == null)
                {
                    _httpContextAccessor.HttpContext.Session.SetObject("cart", new Cart());
                    cartToCheck = _httpContextAccessor.HttpContext.Session.GetObject<Cart>("cart");
                }

                return cartToCheck;
            }

            public void SetCart(Cart cart)
            {
                _httpContextAccessor.HttpContext.Session.SetObject("cart", cart);
            }
        }
}
