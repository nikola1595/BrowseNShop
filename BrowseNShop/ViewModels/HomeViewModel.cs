using BrowseNShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrowseNShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Sneaker> PreferredSneakers { get; set; }

    }
}
