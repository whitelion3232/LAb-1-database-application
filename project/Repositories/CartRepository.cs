using project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Repositories
{
    internal class CartRepository
    {
        private static List<Cart> _carts = new List<Cart>
        {
            new Cart
            {
                Id = 1,
                CreatedDate = DateTime.UtcNow.AddDays(-7),
                UpdatedDate = DateTime.UtcNow.AddDays(-1),
                UserId = 123,
                Articles = new List<Article>
                {
                    new Article { Id = 1, Name = "Article 1", Price = 10.5m, Quantity = 2, Unit = "pcs" },
                    new Article { Id = 2, Name = "Article 2", Price = 5.25m, Quantity = 4, Unit = "pcs" }
                }
            },
            new Cart
            {
                Id = 2,
                CreatedDate = DateTime.UtcNow.AddDays(-14),
                UpdatedDate = DateTime.UtcNow.AddDays(-3),
                UserId = 456,
                Articles = new List<Article>
                {
                    new Article { Id = 3, Name = "Article 3", Price = 7.75m, Quantity = 3, Unit = "kg" },
                    new Article { Id = 4, Name = "Article 4", Price = 2.99m, Quantity = 1, Unit = "kg" },
                    new Article { Id = 5, Name = "Article 5", Price = 1.5m, Quantity = 10, Unit = "pcs" }
                }
            }
        };

        public Cart GetCart(int id)
        {
            return _carts.Find(xyz => xyz.Id == id);
        }

        public List<Cart> GetAllCarts(DateTime updateDate)
        {
            return _carts.FindAll(c => c.UpdatedDate >= updateDate);
        }

        public List<Cart> GetAllCarts()
        {
            return _carts;
        }
    }
    }
