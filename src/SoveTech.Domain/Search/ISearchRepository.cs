using Abp.Domain.Repositories;
using SoveTech.Chuck;
using SoveTech.Search.Enties;
using SoveTech.Swapi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoveTech.Search
{
    public interface ISearchRepository : IRepository
    {
        Task<JokesSearchResults> GetJokes(string query);
        Task<People> GetPerson(string query);
    }
}
