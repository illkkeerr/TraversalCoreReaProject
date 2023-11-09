using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreRea.Areas.Member.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
