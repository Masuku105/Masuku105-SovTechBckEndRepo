
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoveTech.Swapi
{
    public class Swapi : SoveTechAppService, ISwapiAppService
    {
        private readonly ISwapiRepository _swapiRepository;

        public Swapi(ISwapiRepository swapiRepository)
        {
            _swapiRepository = swapiRepository;
        }

        public async Task<PeopleDto> GetPeopleAsync()
        {
            var results = await _swapiRepository.GetPeopleAsync();
            return ObjectMapper.Map<People, PeopleDto>(results);
        }
    }
}
