using System;
using System.Collections.Generic;
using System.Text;

namespace SoveTech.Chuck.ChuckDtos
{
    public class JokeDto
    {
        public List<string> Categories{ get; set; }
        public DateTime Created_At { get; set; }
        public string Icon_Url { get; set; }
        public string Id { get; set; }
        public DateTime Updated_At { get; set; }
        public string Url { get; set; }
        public string Value { get; set; }
    }
}
