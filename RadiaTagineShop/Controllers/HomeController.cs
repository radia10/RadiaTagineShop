using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RadiaTagineShop.Models;
using RadiaTagineShop.ViewModels;

namespace RadiaTagineShop.Controllers
{
    //[Authorize]
    public class HomeController : Controller
    {

        private readonly ITagineRepository _tagineRepository;
        public HomeController(ITagineRepository tagineRepository)
        {
            _tagineRepository = tagineRepository;

        }
        public IActionResult Index()
        {


            var homeViewModel = new HomeViewModel
            {
                TaginesOfTheWeek = _tagineRepository.TaginesOfTheWeek
        };
            return View(homeViewModel);
        }
    }
}
