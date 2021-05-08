using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace AuthorizationHandlerMultipleInvocations.Controllers
{
    public class HomeController : Controller
    {
        [Authorize(Policy = "MyPolicy")]
        public IActionResult Index()
        {
            return Content("Ok");
        }
    }
}
