using BrowseNShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrowseNShop.Data.Models
{
    public class OrderDetail
    {
        public int OrderDetailID { get; set; }

        public int OrderID { get; set; }

        public int SneakerID { get; set; }

        public int Amount { get; set; }

        public decimal Price { get; set; }

        public virtual Sneaker Sneaker { get; set; }
        
        public virtual Order Order { get; set; }
    }
}
