using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrowseNShop.Interfaces;
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


        public ViewResult List()
        {
            var sneakers = _sneakerRepository.Sneakers;
            SneakerListViewModel vm = new SneakerListViewModel();
            vm.Sneakers = _sneakerRepository.Sneakers;
            vm.CurrentCategory = "SneakersCategory";

            return View(vm);
        }

        
    }
}