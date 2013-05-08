using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MovieFu.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext() : base("MovieFu07") { }

        public DbSet<Person> People { get; set; }
    }
}