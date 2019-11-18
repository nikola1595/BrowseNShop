using BrowseNShop.Data.Interfaces;
using BrowseNShop.Data.Models;
using BrowseNShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrowseNShop.Data.Repositories
{
    public class OrderRepository:IOrderRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly ShoppingCart _shoppingCart;

        public OrderRepository(ApplicationDbContext context, ShoppingCart shoppingCart)
        {
            _context = context;
            _shoppingCart = shoppingCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;
            order.OrderTotal = _shoppingCart.GetShoppingTotal();
            _context.Orders.Add(order);


            var shoppingCartItems = _shoppingCart.ShoppingCartItems;

            
            
            foreach(var item in shoppingCartItems)
            {
                var orderDetail = new OrderDetail()
                {
                    Price = item.Sneaker.Price,
                    SneakerID = item.Sneaker.SneakerID,
                    OrderID = order.OrderID,
                    Amount = item.Amount

                      
                 };


                

                _context.OrderDetails.Add(orderDetail);

                
               
            }
            _context.SaveChanges();
        }
    }
}
