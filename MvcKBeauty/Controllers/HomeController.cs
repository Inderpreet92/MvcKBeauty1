using Microsoft.AspNetCore.Mvc;
using MvcKBeauty.Models;

namespace MvcKBeauty.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        // About action method to handle requests to the About Us page
        public IActionResult About()
        {
            return View();
        }

        // Error action method to handle errors
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId =  HttpContext.TraceIdentifier });
        }
    }
}
