using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

namespace MVCSecurityDemo.Controllers
{
    [Authorize]
    public class SecretController : Controller
    {
        
        public ContentResult Secret()
        {
            return Content("Secret informations here");
        }
        [AllowAnonymous]
        public ContentResult PublicInfo()
        {
            return Content("Public informations here");
        }
    }
}
