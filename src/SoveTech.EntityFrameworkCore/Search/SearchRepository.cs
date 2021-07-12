using Newtonsoft.Json;
using SoveTech.Search.Enties;
using SoveTech.Swapi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoveTech.Search
{
    public class SearchRepository : ISearchRepository
    {
        public async Task<JokesSearchResults> GetJokes(string query)
        {
            JokesSearchResults jokesSearchResults = new JokesSearchResults();

            if(query != null)
            {
                string url = "https://api.chucknorris.io/jokes/search?query=" + query;
                var requestResults = await RequestHandler.GetRequestAsync(url);
                jokesSearchResults = JsonConvert.DeserializeObject<JokesSearchResults>(requestResults);

            }         
            
            return jokesSearchResults;
        }

        public async Task<People> GetPerson(string query)
        {
            People results = new People();
            if(query!= null)
            {
                string url = "https://swapi.dev/api/people/?search=" + query;
                var requestResults = await RequestHandler.GetRequestAsync(url);
                results = JsonConvert.DeserializeObject<People>(requestResults);
            }           
            return results;
        }
    }
}
