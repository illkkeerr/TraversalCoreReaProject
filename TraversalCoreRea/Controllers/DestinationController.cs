﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreRea.Controllers
{
	public class DestinationController : Controller
	{
		DestinationManager destinationManager=new DestinationManager(new EfDestinationDal());
		public IActionResult Index()
		{
			var values=destinationManager.TGetList();
			return View(values);
		}
		[HttpGet]
		public IActionResult DestinationDetails(int id)
		{
			ViewBag.id = id;
			var values=destinationManager.TGetById(id);
			return View(values);
		}
		[HttpPost]
		public IActionResult DestinationDetails(Destination p)
		{
			return View();
		}
	}
}
