using BrowseNShop.Interfaces;
using BrowseNShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrowseNShop.Mocks
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category { CategoryName = "Summer Collection", Description = "All summer sneakers"},
                    new Category { CategoryName = "Winter Collection", Description = "All winter sneakers"}
                };

            }
        }
    }
}
