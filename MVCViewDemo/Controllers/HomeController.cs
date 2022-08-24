using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MVCViewDemo.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public string MyController()
        {
            return "Hi, I am a controller";
        }
        public IActionResult MyView()
        {
            return View();
        }
    }
}