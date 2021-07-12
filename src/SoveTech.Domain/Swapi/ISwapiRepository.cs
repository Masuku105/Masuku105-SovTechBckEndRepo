using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoveTech.Swapi
{
    public interface ISwapiRepository : IRepository
    {
        Task<People> GetPeopleAsync();     
    }
}
