using SoveTech.Chuck.ChuckDtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace SoveTech.Chuck
{
    public interface IChuckAppService : IApplicationService
    {
        Task<List<string>> GetAllCategoriesAsync();
        Task<JokeDto> GetRandomCategoryJokeAsync(string category);
    }
}
