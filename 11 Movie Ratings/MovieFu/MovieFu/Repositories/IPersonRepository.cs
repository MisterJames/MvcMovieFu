using MovieFu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
namespace MovieFu.Repositories
{
    public interface IPersonRepository
    {
        IQueryable<Person> Get();
        void Add(Person newPerson);
        Person Get(int id);
        void Delete(int id);
        void Update(Person person);
    }
}
