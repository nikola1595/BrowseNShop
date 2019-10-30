using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BrowseNShop.Models;
using BrowseNShop.Interfaces;
using BrowseNShop.ViewModels;

namespace BrowseNShop.Controllers
{
    public class HomeController : Controller
    {


        private readonly ISneakerRepository _sneakerRepository;
                
        public HomeController(ISneakerRepository sneakerRepository)
        {
            _sneakerRepository = sneakerRepository;
        }


        public ViewResult Index()
        {
            var homeVM = new HomeViewModel
            {
                PreferredSneakers = _sneakerRepository.PreferredSneakers
            };

            return View(homeVM);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
