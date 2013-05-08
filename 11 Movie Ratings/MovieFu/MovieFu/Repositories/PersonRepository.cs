using Angela.Core;
using MovieFu.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MovieFu.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private static readonly MovieContext _context = new MovieContext();

        public IQueryable<Person> Get()
        {
            return _context.People;
        }
                
        public void Add(Person newPerson)
        {
            _context.People.Add(newPerson);
            _context.SaveChanges();
        }

        public Person Get(int id)
        {
            return _context.People.Find(id);
        }

        public void Delete(int id)
        {
            var person = Get(id);
            _context.People.Remove(person);
            _context.SaveChanges();
        }

        public void Update(Person person)
        {
            var oldPerson = Get(person.Id);
            _context.Entry(oldPerson).CurrentValues.SetValues(person);
            _context.SaveChanges();
        }

    }
}