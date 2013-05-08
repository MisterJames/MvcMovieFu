using MovieFu.Models;
using System;
using System.Collections.Generic;
namespace MovieFu.Repositories
{
    public interface IPersonRepository
    {
        List<Person> Get();
        void Add(Person newPerson);
        Person Get(int id);
        void Delete(int id);
        void Update(Person person);
    }
}
