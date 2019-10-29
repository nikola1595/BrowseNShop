using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrowseNShop.Data.Models;
using BrowseNShop.Interfaces;
using BrowseNShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BrowseNShop.Controllers
{

    public class ShoppingCartController : Controller
    {
        private readonly ISneakerRepository _sneakerRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(ISneakerRepository sneakerRepository, ShoppingCart shoppingCart)
        {
            _sneakerRepository = sneakerRepository;
            _shoppingCart = shoppingCart;

        }


        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;


            var SCVM = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingTotal()

            };


            return View(SCVM);
        }



        public RedirectToActionResult AddToShoppingCart(int sneakerID)
        {
            var selectedSneaker = _sneakerRepository.Sneakers.FirstOrDefault(f => f.SneakerID == sneakerID);

            if (selectedSneaker != null)
            {
                _shoppingCart.AddToCart(selectedSneaker, 1);

            }
            return RedirectToAction("Index");
        }



        public RedirectToActionResult RemoveFromShoppingCart(int sneakerID)
        {
            var selectedSneaker = _sneakerRepository.Sneakers.FirstOrDefault(f => f.SneakerID == sneakerID);

            if(selectedSneaker != null)
            {
                _shoppingCart.RemoveFromCart(selectedSneaker);
            }

            return RedirectToAction("Index");
        }

        
    }
}