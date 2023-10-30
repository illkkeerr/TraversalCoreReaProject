using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreRea.ViewComponents.Default
{
	public class _SliderPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
