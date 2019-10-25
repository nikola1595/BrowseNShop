using BrowseNShop.Interfaces;
using BrowseNShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrowseNShop.Mocks
{
    public class MockSneakerRepository : ISneakerRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Sneaker> Sneakers
        {
            get
            {
                return new List<Sneaker>
                {
                    new Sneaker
                    {
                        Name = "New Balance 991.9",
                        Price = 180,
                        ShortDescription = "NB 991.9",
                        LongDescription = "Mixing sole units and uppers from different models has become a sneaker trend for sneaker brands lately. Sadly, it tends to be lazily executed and seldom yields wearable results. Still, now and again there’s an exception to the rule, which this season comes courtesy of Bostonian running and lifestyle legend New Balance.",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "summersneaker-19-1.jpg",
                        InStock = true,
                        IsPreferred = true,
                        ImageThumbnailUrl = "s-l225.jpg"
                    }


                };
            }
        }
        public IEnumerable<Sneaker> PreferredSneakers { get; }
        public Sneaker GetSneakerById(int sneakerID)
        {
            throw new NotImplementedException();
        }
    }
}
