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
    [Route("api/[controller]")]
    public class SneakerDetailsController : Controller
    {
        public readonly ISneakerRepository _sneakerRepository;

        public SneakerDetailsController(ISneakerRepository sneakerRepository)
        {
            _sneakerRepository = sneakerRepository;
        }


        private SneakerViewModel MapDbSneakerToSneakerViewModel(Sneaker dbSneaker) => new SneakerViewModel
        {
            SneakerID = dbSneaker.SneakerID,
            Name = dbSneaker.Name,
            Price = dbSneaker.Price,
            ShortDescription = dbSneaker.ShortDescription,
            ImageThumbnailUrl = dbSneaker.ImageThumbnailUrl
        };


        [HttpGet]
        public IEnumerable<SneakerViewModel> LoadMoreSneakers()
        {
            IEnumerable<Sneaker> dbSneakers = null;

            dbSneakers = _sneakerRepository.Sneakers.OrderBy(s => s.SneakerID).Take(10);

            List<SneakerViewModel> sneakers = new List<SneakerViewModel>();

            foreach(var sneaker in dbSneakers)
            {
                sneakers.Add(MapDbSneakerToSneakerViewModel(sneaker));
            }
            return sneakers;
        }

        
    }
}