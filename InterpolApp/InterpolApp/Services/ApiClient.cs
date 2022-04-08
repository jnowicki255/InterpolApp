using InterpolApp.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace InterpolApp.Services
{
    public class ApiClient : IApiClient
    {
        private readonly HttpClient client;

        public ApiClient()
        {
            client = new HttpClient();
        }

        public async Task<NoticesQuery> GetRedNoticesAsync()
        {
            var result = await client.GetAsync("https://ws-public.interpol.int/notices/v1/red?resultPerPage=20");

            if (result.IsSuccessStatusCode)
            {
                return await result.Content.ReadAsAsync<NoticesQuery>();
            }

            return null;
        }
    }
}
