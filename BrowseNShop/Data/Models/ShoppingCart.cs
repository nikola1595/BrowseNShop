using BrowseNShop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrowseNShop.Data.Models
{
    public class ShoppingCart
    {
        private readonly ApplicationDbContext _context;

        public ShoppingCart(ApplicationDbContext context)
        {
            _context = context;
        }


        public string ShoppingCartID { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }




        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var context = services.GetService<ApplicationDbContext>();

            string cartID = session.GetString("CartID") ?? Guid.NewGuid().ToString();

            session.SetString("CartID", cartID);


            return new ShoppingCart(context)
            {
                ShoppingCartID = cartID
            };
        }



        public void AddToCart(Sneaker sneaker, int amount)
        {
            var shoppingCartItem = _context.ShoppingCartItems.SingleOrDefault(
                s => s.Sneaker.SneakerID == sneaker.SneakerID && s.ShoppingCartID == ShoppingCartID);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartID = ShoppingCartID,
                    Sneaker = sneaker,
                    Amount = 1
                };

                _context.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }

            _context.SaveChanges();

        }


        
        public int RemoveFromCart(Sneaker sneaker)
        {
            var shoppingCartItem = _context.ShoppingCartItems.SingleOrDefault(
                s => s.Sneaker.SneakerID == sneaker.SneakerID && s.ShoppingCartID == ShoppingCartID);


            var localAmount = 0;

            if(shoppingCartItem != null)
            {
                if(shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
                    _context.ShoppingCartItems.Remove(shoppingCartItem);
                }


            }


            _context.SaveChanges();


            return localAmount;
        }




        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ?? (ShoppingCartItems = _context.ShoppingCartItems.Where(
                s => s.ShoppingCartID == ShoppingCartID).Include(s => s.Sneaker).ToList());
        }



        public void ClearCart()
        {
            var cartItems = _context.ShoppingCartItems.Where(c => c.ShoppingCartID == ShoppingCartID);


            _context.ShoppingCartItems.RemoveRange(cartItems);


            _context.SaveChanges();
        }


        
        public decimal GetShoppingTotal()
        {
            var total = _context.ShoppingCartItems.Where(c => c.ShoppingCartID == ShoppingCartID)
                .Select(c => c.Sneaker.Price * c.Amount).Sum();



            return total;
        }


    }
}
