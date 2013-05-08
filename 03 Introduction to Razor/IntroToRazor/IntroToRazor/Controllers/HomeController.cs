using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroToRazor.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.PossibleCountries = new List<SelectListItem>() { 
                new SelectListItem{ Text = "Canada"},
                new SelectListItem{ Text = "United States"},
                new SelectListItem{ Text = "China"},
                new SelectListItem{ Text = "Ukraine"},
                new SelectListItem{ Text = "India"}
            };
            return View();
        }

    }
}
