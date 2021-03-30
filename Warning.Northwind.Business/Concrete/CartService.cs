using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Warning.Northwind.Business.Abstract;
using Warning.Northwind.Entities.Concrete;

namespace Warning.Northwind.Business.Concrete
{
    public class CartService : ICartService
    {
        public void AddToCart(Cart cart, Product product)
        {
            CartLine cartLine = cart.CartLines.FirstOrDefault(c => c.Product.PRoductId == product.PRoductId);
            if (cartLine != null)
            {
                cartLine.Quantity++;
                return;
            }
            cart.CartLines.Add(new CartLine { Product = product ,Quantity=1});
        }

        public List<CartLine> List(Cart cart)
        {
            return cart.CartLines;
        }

        public void RemoveFromCart(Cart cart, int productId)
        {
            cart.CartLines.Remove(cart.CartLines.FirstOrDefault(c => c.Product.PRoductId == productId));

        }
    }
}
