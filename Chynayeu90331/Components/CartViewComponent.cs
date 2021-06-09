using Chynayeua90331.Models;
using Microsoft.AspNetCore.Mvc;

namespace Chynayeua90331.Components
{
    public class CartViewComponent : ViewComponent

    {
        private Cart _cart;
        public CartViewComponent(Cart cart)
        {
            _cart = cart;
        }

        public IViewComponentResult Invoke()
        {
            return View(_cart);
        }
    }
}
