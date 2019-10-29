using BrowseNShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrowseNShop.Data.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemID { get; set; }

        public Sneaker Sneaker { get; set; }

        public int Amount { get; set; }

        public string ShoppingCartID { get; set; }

    }
}
