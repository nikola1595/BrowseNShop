using BrowseNShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrowseNShop.ViewModels
{
    public class SneakerListViewModel
    {
        public IEnumerable<Sneaker> Sneakers { get; set;}
        public string CurrentCategory { get; set; }
    }
}
