using SoveTech.Chuck.ChuckDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoveTech.Search.SearchDtos
{
    public class JokesSearchResultsDto
    {
        public int Total { get; set; }
        public List<JokeDto> Result { get; set; }
    }
}
