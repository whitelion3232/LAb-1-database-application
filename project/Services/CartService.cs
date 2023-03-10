using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project.Models;
using project.Repositories;

namespace project.Services
{
    internal class CartService
    {
        private readonly CartRepository _cartRepository;

        public CartService(CartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        public List<Cart> GetAllCarts()
        {
            var carts = _cartRepository.GetAllCarts();

            foreach (var cart in carts)
            {
                cart.Value = cart.Articles.Sum(a => a.Price * a.Quantity);
            }

            return carts;
        }
    }
}
