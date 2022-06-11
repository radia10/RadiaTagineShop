using Microsoft.AspNetCore.Mvc;
using RadiaTagineShop.Controllers;
using RadiaTagineShop.Models;
using RadiaTagineShop.ViewModels;

namespace RadiaTagineShop.Components
{
    public class ShoppingCartSummary:ViewComponent
    {
        private readonly ShoppingCart _shoppingCart;
        public ShoppingCartSummary(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;

        }

        public IViewComponentResult Invoke()
        {
            var items=_shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems=items;
            var shoppingCartViewModel =new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(shoppingCartViewModel);

        }


    }
}
