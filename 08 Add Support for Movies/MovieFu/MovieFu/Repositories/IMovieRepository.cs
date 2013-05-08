using MovieFu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFu.Repositories
{
    public interface IMovieRepository
    {
        IQueryable<Movie> Get();
        void Add(Movie newMovie);
        Movie Get(int id);
        void Delete(int id);
        void Update(Movie movie);
    }
}
