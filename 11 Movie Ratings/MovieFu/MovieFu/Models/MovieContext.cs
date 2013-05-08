using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MovieFu.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext() : base("MovieFu11") { }

        public DbSet<Person> People { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Rating> Ratings { get; set; }

    }
}