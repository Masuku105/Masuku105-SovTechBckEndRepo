using Abp.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;


namespace SoveTech
{
    public class RequestHandler 
    {
       static readonly HttpClient _httpClient = new HttpClient();
        public async static Task<string> GetRequestAsync(string url)
        {            
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }
            catch (HttpRequestException e)
            {
                return e.Message;
            }
        }
    }
}
