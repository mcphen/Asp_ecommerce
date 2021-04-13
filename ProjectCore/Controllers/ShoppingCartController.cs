using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectCore.Models;
using ProjectCore.Repository;
using ProjectCore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCore.Controllers
{
    public class ShoppingCartController : Controller
    {

        private readonly IBookRepository _bookRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IBookRepository bookRepository, ShoppingCart shoppingCart)
        {
            _bookRepository = bookRepository;
            _shoppingCart = shoppingCart;
        }
        // GET: ShoppingCartController
        public ActionResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;
            var shoppingCartViewModel = new ShoppingCartViewModel();
            shoppingCartViewModel.ShoppingCart = _shoppingCart;
            shoppingCartViewModel.ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal();
            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int idBook)
        {
            var book = _bookRepository.GetBookId(idBook);
            if (book != null)
            {
                _shoppingCart.AddToCart(book, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int idBook)
        {
            var book = _bookRepository.GetBookId(idBook);
            if (book != null)
            {
                _shoppingCart.RemoveFromCart(book);
            }
            return RedirectToAction("Index");
        }


    }
}
