using RssView.ApplicationServices;
using RssView.DomainServices;
using RssView.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace RssView.Controllers
{
    public class HomeController : Controller
    {
        private readonly HomeService _homeService;
        public HomeController(HomeService homeService)
        {
            _homeService = homeService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM()
            {
                Posts = _homeService.GetAllPostsFromRss()
            };
            return View(homeVM);
        }

    }
}
