using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrowseNShop.Interfaces;
using BrowseNShop.Models;
using BrowseNShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BrowseNShop.Controllers
{
    public class SneakerController : Controller
    {
        private readonly ISneakerRepository _sneakerRepository;
        private readonly ICategoryRepository _categoryRepository;

        public SneakerController(ICategoryRepository categoryRepository, ISneakerRepository sneakerRepository)
        {
            _categoryRepository = categoryRepository;
            _sneakerRepository = sneakerRepository;
        }


        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Sneaker> sneakers;

            string currentCategory = string.Empty;

            if(string.IsNullOrEmpty(category))
            {
                sneakers = _sneakerRepository.Sneakers.OrderBy(s => s.SneakerID);
                currentCategory = "Sneakers and boots";
            }
            else
            {
                if(string.Equals("Summer Collection",_category,StringComparison.OrdinalIgnoreCase))
                {
                    sneakers = _sneakerRepository.Sneakers.Where(s => s.Category.CategoryName.Equals("Summer Collection"));
                }
                else
                {
                    sneakers = _sneakerRepository.Sneakers.Where(w => w.Category.CategoryName.Equals("Winter Collection"));
                }
                currentCategory = _category;
            }

            var sneakerListViewModel = new SneakerListViewModel
            {
                Sneakers = sneakers,
                CurrentCategory = currentCategory
            };

            return View(sneakerListViewModel);

        }


        public ViewResult Search(string strSearch)
        {
            string _strSearch = strSearch;
            IEnumerable<Sneaker> sneakers;
            string currentCategory = string.Empty;

            if(string.IsNullOrEmpty(_strSearch))
            {
                sneakers = _sneakerRepository.Sneakers.OrderBy(s => s.SneakerID);
            }
            else
            {
                sneakers = _sneakerRepository.Sneakers.Where(s => s.Name.ToLower().Contains(_strSearch.ToLower()));
            }

            return View("~/Views/Sneaker/List.cshtml", new SneakerListViewModel { Sneakers = sneakers, CurrentCategory = "All sneakers and boots" });

        }


        public ViewResult Details(int sneakerID)
        {
            var sneaker = _sneakerRepository.Sneakers.FirstOrDefault(s => s.SneakerID == sneakerID);
            if(sneaker == null)
            {
                return View("~/Views/Error/Error.cshtml");
            }

            return View(sneaker);
        }

        
    }
}