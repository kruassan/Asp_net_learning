using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Beg2.Models;
namespace Beg2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
			string dt = DateTime.Now.ToLongDateString();
			ViewBag.datetime_now = dt;
			return View();
        }

		[HttpGet]
		public ViewResult Authentification()
		{
			return View();
		}

		[HttpPost]
		public ViewResult Authentification(AuthentificationData authData)
		{
			if (ModelState.IsValid)
			{
				return View("User", authData);
			}
			else
			{
				return View();
			}
		}
	}
}