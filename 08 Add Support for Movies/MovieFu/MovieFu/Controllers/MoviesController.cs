using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieFu.Models;
using MovieFu.Repositories;
using BootstrapMvcSample.Controllers;

namespace MovieFu.Controllers
{   
    public class MoviesController : BootstrapBaseController
    {
        //private MovieContext context = new MovieContext();

        private readonly IMovieRepository _movieRepository;
        private readonly IPersonRepository _personRepository;

        public MoviesController(IMovieRepository movieRepository, IPersonRepository personRepository)
        {
            _movieRepository = movieRepository;
            _personRepository = personRepository;
        }

        public ViewResult Index()
        {
            return View(_movieRepository.Get().ToList());
        }

        //
        // GET: /Movies/Details/5

        public ViewResult Details(int id)
        {
            Movie movie = _movieRepository.Get().Single(x => x.Id == id);
            return View(movie);
        }

        //
        // GET: /Movies/Create

        public ActionResult Create()
        {
            ViewBag.PossibleDirectors = _personRepository.Get();
            var movie = new Movie();
            return View(movie);
        } 

        //
        // POST: /Movies/Create

        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _movieRepository.Add(movie);
                Success("Your movie has been added.");
                return RedirectToAction("Index");  
            }

            ViewBag.PossibleDirectors = _personRepository.Get();
            return View(movie);
        }
        
        //
        // GET: /Movies/Edit/5
 
        public ActionResult Edit(int id)
        {
            Movie movie = _movieRepository.Get().Single(x => x.Id == id);
            ViewBag.PossibleDirectors = _personRepository.Get();
            return View(movie);
        }

        //
        // POST: /Movies/Edit/5

        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _movieRepository.Update(movie);
                Success("Your movie was updated");
                return RedirectToAction("Index");
            }
            
            Error("Could not save your movie");
            ViewBag.PossibleDirectors = _personRepository.Get();
            return View(movie);
        }

        //
        // GET: /Movies/Delete/5
 
        public ActionResult Delete(int id)
        {
            Movie movie = _movieRepository.Get(id);
            Attention("You are deleting this movie.");
            return View(movie);
        }

        //
        // POST: /Movies/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            _movieRepository.Delete(id);
            Success("Your movie was deleted");
            return RedirectToAction("Index");
        }

        public ActionResult Null()
        {
            return null;
        }

    }
}