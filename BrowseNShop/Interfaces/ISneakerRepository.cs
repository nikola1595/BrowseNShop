using BrowseNShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrowseNShop.Interfaces
{
    public interface ISneakerRepository
    {
        IEnumerable<Sneaker> Sneakers { get; }
        IEnumerable<Sneaker> PreferredSneakers { get; }
        Sneaker GetSneakerById(int sneakerID);

    }
}
