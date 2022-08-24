using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace MVCFirstApp.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Search(string name = "No name Entered")
        {
            var input = WebUtility.HtmlEncode(name);         
            return Content(input);
        }
        [HttpGet]
        public IActionResult Search()
        {
            var input = "Another Search action";
            return Content(input);
        }
    }
}
