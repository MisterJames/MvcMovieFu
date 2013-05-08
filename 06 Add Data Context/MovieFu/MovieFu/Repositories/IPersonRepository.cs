using MovieFu.Models;
using System;
using System.Collections.Generic;
namespace MovieFu.Repositories
{
    public interface IPersonRepository
    {
        List<Person> Get();
    }
}
