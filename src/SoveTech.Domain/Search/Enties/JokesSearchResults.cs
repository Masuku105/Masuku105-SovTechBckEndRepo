using SoveTech.Chuck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoveTech.Search.Enties
{
    public class JokesSearchResults
    {
        public int Total { get; set; }
        public List<Joke> Result { get; set; }
    }
}
