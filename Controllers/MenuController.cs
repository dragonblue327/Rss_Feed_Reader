using System.Linq;
using System.Security.Policy;
using RssView.ApplicationServices;
using RssView.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RssView.Controllers
{
    public class MenuController : Controller
    {
        private readonly MenuService _menuService;
        public MenuController(MenuService menuService)
        {
            _menuService = menuService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            MenuVM menuVM = new MenuVM()
            {
                FrequencyRefreshInMinutes = _menuService.GetFrequencyRefreshInSerconds()/60,
                Urls = _menuService.GetUrls().Select(url => new SelectListItem()
                    {
                        Text = url,
                        Value = url.ToString()
                    })
            };
            return View(menuVM);
        }
        [HttpPost]
        public IActionResult DeleteUrl(string url)
        {
            if (_menuService.DeleteUrl(url))
            {
                var Urls = _menuService.GetUrls().Select(url => new SelectListItem()
                {
                    Text = url,
                    Value = url.ToString()
                });
                return PartialView("../Menu/Partials/_ListUrlsDelete", Urls);
            }
            else return NotFound();
        }

        [HttpPost]
        public IActionResult AddUrl(string url)
        {
            if (_menuService.CheckUrl(url))
            {
                _menuService.AddUrl(url);
                return PartialView("../Menu/Partials/_infoModal", url);
            }
            return PartialView("../Menu/Partials/_infoModal", "");
        }

        [HttpPost]
        public IActionResult ChangeFrequency(string frequency)
        {
            _menuService.ChangeFrequency(frequency);
            return RedirectToAction(nameof(Index));
        }
    }
}
