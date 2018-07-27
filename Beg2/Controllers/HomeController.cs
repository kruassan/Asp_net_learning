using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Beg2.Models;

using Beg2.Entity_framework.DataModel;
using Beg2.Entity_framework.Contexts;

namespace Beg2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
			string dt = DateTime.Now.ToLongDateString();

			DataModelContext context = new DataModelContext("public");

			ViewBag.showing_data = context.Newss.First(i => i.Id == 1).Content;

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
				DataModelContext db = new DataModelContext("public");
				//if (db.Users.FirstOrDefault(i => i.Login == authData.login) != null)
				//{
					return View("User", authData);
				//}
				//else
				//{
				//	return View();
				//}
			}
			else
			{
				return View();
			}
		}
	}
}