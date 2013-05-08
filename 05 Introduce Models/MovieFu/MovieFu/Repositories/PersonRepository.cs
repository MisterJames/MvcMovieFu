using Angela.Core;
using MovieFu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieFu.Repositories
{
    public class PersonRepository
    {
        private static readonly List<Person> _people;

        static PersonRepository()
        {
            _people = new List<Person>();

            // make your own fake data...
            _people.Add(new Person { Id = 1, FirstName = "Bill", LastName = "Peters", EmailAddress = "foo@bar.com", PhoneNumber = "(306) 555-1234" });
            _people.Add(new Person { Id = 2, FirstName = "Bob", LastName = "Potter", EmailAddress = "fu@bar.com", PhoneNumber = "(306) 555-4321" });
            _people.Add(new Person { Id = 3, FirstName = "Susan", LastName = "Piper", EmailAddress = "bizz@buzz.com", PhoneNumber = "(306) 555-1111" });
            _people.Add(new Person { Id = 4, FirstName = "Jack", LastName = "Pecks", EmailAddress = "me@company.com", PhoneNumber = "(306) 555-5555" });
            // ... etc... 
            _people.Add(new Person { Id = 15, FirstName = "Jill", LastName = "Pickles", EmailAddress = "jill@pickles.com", PhoneNumber = "(306) 999-0123" });

            // or, have AngelaSmith do it for you...
            _people = Angie.FastList<Person>(15);

        }

        public List<Person> Get()
        {
            return _people;
        }



    }
}