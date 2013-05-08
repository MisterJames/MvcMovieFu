using MovieFu.Models;
using MovieFu.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieFu.Controllers
{
    public class PersonController : Controller
    {
        //
        // GET: /Person/

        public ActionResult Index()
        {
            var personRepository = new PersonRepository();
            var people = personRepository.Get();
            
            return View(people);
        }

    }
}
