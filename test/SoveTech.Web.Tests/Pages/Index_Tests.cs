using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace SoveTech.Pages
{
    public class Index_Tests : SoveTechWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
