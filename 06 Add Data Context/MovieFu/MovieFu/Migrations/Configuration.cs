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
        }
    }
}
