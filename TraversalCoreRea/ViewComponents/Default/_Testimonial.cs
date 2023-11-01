using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreRea.ViewComponents.Default
{
	public class _Testimonial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
