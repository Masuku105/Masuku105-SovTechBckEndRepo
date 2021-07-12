using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoveTech.Swapi
{
    public class SwapiRepository : ISwapiRepository
    {
       
        public async Task<People> GetPeopleAsync()
        {
            string url = "https://swapi.dev/api/people";
            var requestResults = await RequestHandler.GetRequestAsync(url);               
            var people = JsonConvert.DeserializeObject<People>(requestResults);
            return people;
        }
    
    }
}
