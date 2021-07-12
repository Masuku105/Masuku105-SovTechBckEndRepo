using SoveTech.Chuck.ChuckDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoveTech.Chuck
{
    public class Chuck : SoveTechAppService, IChuckAppService
    {
        private readonly IChuckRepository _chuckRepository;

        public Chuck(IChuckRepository chuckRepository)
        {
            _chuckRepository = chuckRepository;
        }
        public async Task<List<string>> GetAllCategoriesAsync()
        {
            var results = await _chuckRepository.GetAllCategoriesAsync();
            return results;
        }

        public async Task<JokeDto> GetRandomCategoryJokeAsync(string category)
        {
            var results = await _chuckRepository.GetRandomCategoryJokeAsync(category);
            return ObjectMapper.Map<Joke, JokeDto>(results);
        }
    }
}
