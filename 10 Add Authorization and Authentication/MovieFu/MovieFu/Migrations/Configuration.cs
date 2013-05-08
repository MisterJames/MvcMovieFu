namespace MovieFu.Migrations
{
    using Angela.Core;
    using MovieFu.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MovieFu.Models.MovieContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MovieFu.Models.MovieContext context)
        {
            if (context.People.Count() == 0)
            {
                List<Person> people = Angie.FastList<Person>(15);
                people.ForEach(p => context.People.Add(p));
                context.SaveChanges();
            }
            
            if (context.Movies.Count() == 0)
            {
                List<Movie> movies = new List<Movie>();
                
                // use a random director...
                movies.Add(new Movie { Title = "Flight of the Navigator", Description = "Twister Sister is a group of men. Oh, yes.", Director = context.People.OrderBy(p => Guid.NewGuid()).First(), ReleaseYear = 1986 });
                
                // ...or create a known one
                var person = new Person { FirstName = "George", LastName = "Lucas", EmailAddress = "george@lucas.com" };
                var people = new List<Person>() { person };
                context.People.AddOrUpdate(p => p.EmailAddress, people.ToArray());
                movies.Add(new Movie { Title = "Raiders of the Lost Ark", Description = "Han always shoots first.", Director = person, ReleaseYear = 1981 });
                movies.Add(new Movie { Title = "A New Hope", Description = "Whiny farm boy saves the princess.", Director = person, ReleaseYear = 1977 });
                
                movies.ForEach(m => context.Movies.Add(m));
                context.SaveChanges();
            }
        }
    }
}
