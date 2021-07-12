using SoveTech.Search.SearchDtos;
using SoveTech.Swapi;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace SoveTech.Search
{
    public interface ISearchAppService : IApplicationService
    {
        Task<JokesSearchResultsDto> GetJokes(string query);
        Task<PeopleDto> GetPerson(string query);
    }
}
