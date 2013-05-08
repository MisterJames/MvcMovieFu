using BootstrapMvcSample.Controllers;
using MovieFu.Models;
using MovieFu.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieFu.Controllers
{
    public class PersonController : BootstrapBaseController
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

        public ActionResult Create()
        {
            var person = new Person();
            return View(person);
        }

        [HttpPost]
        public ActionResult Create(Person person)
        {
            if (ModelState.IsValid)
            {
                _repository.Add(person);
                Success("Your information was saved!");
                return RedirectToAction("Index");
            }
            Error("there were some errors in your form.");
            return View(person);
            
        }

        public ActionResult Details(int id)
        {
            var person = _repository.Get(id);
            return View(person);
        }

        public ActionResult Delete(int id)
        {
            var person = _repository.Get(id);
            Attention("You will be deleting this record.");
            return View(person);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            _repository.Delete(id);
            Success("The record was deleted.");
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            return View(_repository.Get(id));
        }

        [HttpPost]
        public ActionResult Edit(Person person)
        {
            if (ModelState.IsValid)
            {
                _repository.Update(person);
                Success("Your record was updated.");
                return RedirectToAction("Index");
            }

            Error("There was a problem saving your record");
            return View(person);
        }

        public ActionResult Null()
        {
            return null;
        }

    }
}
