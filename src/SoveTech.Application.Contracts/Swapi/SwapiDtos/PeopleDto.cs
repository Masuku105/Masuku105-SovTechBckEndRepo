using SoveTech.Swapi.SwapiDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoveTech.Swapi
{
    public class PeopleDto
    {
        public int Count { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
        public List<ResultDto> Results { get; set; }
    }
}
