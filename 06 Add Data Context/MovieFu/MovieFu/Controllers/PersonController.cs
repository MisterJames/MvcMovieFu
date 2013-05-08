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
        private readonly IPersonRepository _repository;

        public PersonController(IPersonRepository repository)
        {
            _repository = repository;
        }

        public ActionResult Index()
        {
            var people = _repository.Get();
            
            return View(people);
        }

    }
}
