using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreRea.Areas.Member.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
