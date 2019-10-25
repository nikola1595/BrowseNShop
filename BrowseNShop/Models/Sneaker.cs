﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrowseNShop.Models
{
    public class Sneaker
    {
        public int SneakerID { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsPreferred { get; set; }
        public bool InStock { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

    }
}
