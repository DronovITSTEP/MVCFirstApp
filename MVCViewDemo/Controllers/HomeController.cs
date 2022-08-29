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

        public ActionResult MyController()
        {
            ViewData["Message"] = "Testing method1";
            return View();
        }
        public IActionResult MyView()
        {
            return View();
        }
    }
}