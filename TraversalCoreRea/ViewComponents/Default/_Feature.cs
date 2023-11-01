using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreRea.ViewComponents.Default
{
	public class _Feature:ViewComponent
	{
		FeatureManager _featureManager=new FeatureManager(new EfFeatureDal());
		public IViewComponentResult Invoke()
		{
			var values = _featureManager.TGetList();
			ViewBag.v1 = values[0];
			ViewBag.v2 = values[1];
			ViewBag.v3 = values[2];
			ViewBag.v4 = values[3];
			ViewBag.v5 = values[4];
			
			return View();
		}
	}
}
