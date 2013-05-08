using MovieFu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;

namespace MovieFu.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private static readonly MovieContext _context = new MovieContext();

        public IQueryable<Models.Movie> Get()
        {
            return _context.Movies.Include(m => m.Director).Include(m => m.Ratings);
        }

        public void Add(Models.Movie newMovie)
        {
            _context.Movies.Add(newMovie);
            _context.SaveChanges();
        }

        public Models.Movie Get(int id)
        {
            return _context.Movies.Find(id);
        }

        public void Delete(int id)
        {
            var movie = Get(id);
            _context.Movies.Remove(movie);
            _context.SaveChanges();
        }

        public void Update(Movie movie)
        {
            var oldMovie = Get(movie.Id);
            _context.Entry(oldMovie).CurrentValues.SetValues(movie);
            _context.SaveChanges();
        }


        public void AddMovieRating(Rating rating)
        {
            _context.Ratings.Add(rating);
            _context.SaveChanges();
        }
    }
}