using BrowseNShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrowseNShop.Interfaces
{
    interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }



    }
}
