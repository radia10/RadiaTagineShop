using Microsoft.AspNetCore.Mvc;
using RadiaTagineShop.Models;
using RadiaTagineShop.ViewModels;
using System.Linq;

namespace RadiaTagineShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ITagineRepository _tagineRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(ITagineRepository tagineRepository, ShoppingCart shoppingCart)
        {
            _tagineRepository = tagineRepository;
            _shoppingCart = shoppingCart;
        }
        public IActionResult Index()
        {

            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }


        public RedirectToActionResult AddToShoppingCart(int tagineId)
        {
            var selectedTagine = _tagineRepository.AllTagines.FirstOrDefault(t => t.TagineId == tagineId);

            if (selectedTagine != null)
            {
                _shoppingCart.AddToCart(selectedTagine, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int tagineId)
        {
            var selectedTagine = _tagineRepository.AllTagines.FirstOrDefault(t => t.TagineId == tagineId);

            if (selectedTagine != null)
            {
                _shoppingCart.RemoveFromCart(selectedTagine);
            }
            return RedirectToAction("Index");
        }
    }
}
