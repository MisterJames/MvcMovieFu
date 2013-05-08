using Angela.Core;
using MovieFu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieFu.Repositories
{
    public class PersonRepository : MovieFu.Repositories.IPersonRepository
    {
        private static readonly MovieContext _context = new MovieContext();

        public List<Person> Get()
        {
            return _context.People.ToList();
        }



    }
}