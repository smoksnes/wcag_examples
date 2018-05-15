using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WCAG.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Clip()
		{
			return View();
		}

		public ActionResult AriaTooltip()
		{
			return View();
		}

		public ActionResult Focus()
		{
			return View();
		}
	}
}