using project.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Views
{
    internal class CartView
    {
        private readonly CartService _cartService;

        public CartView(CartService cartService)
        {
            _cartService = cartService;
        }

        public void ShowAllCarts()
        {
            var carts = _cartService.GetAllCarts();

            foreach (var cart in carts)
            {
                Console.WriteLine($"Cart {cart.Id}: Total value = {cart.Value}");
            }
        }
    }
}
