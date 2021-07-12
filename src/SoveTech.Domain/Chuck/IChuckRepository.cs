using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace SoveTech.Chuck
{
    public interface IChuckRepository : IRepository
    {
        Task<List<string>> GetAllCategoriesAsync();
        Task<Joke> GetRandomCategoryJokeAsync(string Category);

    }
}
