using Microsoft.AspNetCore.Mvc;

namespace MVCFirstApp.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "This is ASP.NET MVC";
        }
        [ActionName("CurrentTime")]
        public string GetCurrentTime()
        {
            return TimeString();
        }
        [NonAction]
        public string TimeString()
        {
            return DateTime.Now.ToString();
        }
    }
}
/*
HttpGet
HttpPost
HttpPut
HttpDelete
HttpOptions
HttpPatch
 */