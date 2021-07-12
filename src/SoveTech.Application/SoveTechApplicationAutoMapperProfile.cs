using AutoMapper;
using SoveTech.Chuck;
using SoveTech.Chuck.ChuckDtos;
using SoveTech.Search.Enties;
using SoveTech.Search.SearchDtos;
using SoveTech.Swapi;
using SoveTech.Swapi.Entities;
using SoveTech.Swapi.SwapiDtos;

namespace SoveTech
{
    public class SoveTechApplicationAutoMapperProfile : Profile
    {
        public SoveTechApplicationAutoMapperProfile()
        {       
            CreateMap<Joke, JokeDto>();
            CreateMap<People, PeopleDto>();           
            CreateMap<Result, ResultDto>();
            CreateMap<JokesSearchResults, JokesSearchResultsDto>();
        }
    }
}
