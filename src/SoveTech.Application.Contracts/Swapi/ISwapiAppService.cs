using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace SoveTech.Swapi
{
    public interface ISwapiAppService : IApplicationService
    {
        Task<PeopleDto> GetPeopleAsync();        
    }
}
