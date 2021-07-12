using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SoveTech.Chuck
{
    public class ChuckRepository : IChuckRepository
    {    

        
        public async Task<List<string>> GetAllCategoriesAsync()
        {
            string url = "https://api.chucknorris.io/jokes/categories";
            var results = await RequestHandler.GetRequestAsync(url);
            List<string> categories = JsonConvert.DeserializeObject<List<string>>(results);
            return categories;
        }

        public async Task<Joke> GetRandomCategoryJokeAsync(string category)
        {
            string url = "https://api.chucknorris.io/jokes/random?category=";
            var results = await RequestHandler.GetRequestAsync(url + category);
            Joke categoryJoke = JsonConvert.DeserializeObject<Joke>(results);
            return categoryJoke;
        }
    }
}
