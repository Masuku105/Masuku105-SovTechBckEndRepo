
using SoveTech.Search.Enties;
using SoveTech.Search.SearchDtos;
using SoveTech.Swapi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoveTech.Search
{
    public class Search : SoveTechAppService, ISearchAppService
    {
        private readonly ISearchRepository _searchRepository;

        public Search(ISearchRepository searchRepository)
        {
            _searchRepository = searchRepository;


        }
        public async Task<JokesSearchResultsDto> GetJokes(string query)
        {
            var result = await _searchRepository.GetJokes(query);
            return ObjectMapper.Map<JokesSearchResults, JokesSearchResultsDto>(result);
        }

        public async Task<PeopleDto> GetPerson(string query)
        {
            var results = await _searchRepository.GetPerson(query);
            return ObjectMapper.Map<People, PeopleDto>(results);
        }
    }
}
