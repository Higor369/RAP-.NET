using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotBlaze
{
    public class BlazeService
    {
        private HttpClient _client;

        public BlazeService()
        {
            _client = new HttpClient()
            {
                BaseAddress = new Uri("https://blaze.com/")
            };

            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<Blaze> GetLastResultBlaze()
        {
            var response = await _client.GetAsync("api/roulette_games/recent").Result.Content.ReadAsStringAsync();

            var blaze = JsonConvert.DeserializeObject<List<Blaze>>(response);

            return blaze.First();
        }


        public async Task<List<Blaze>> GetBlazes()
        {
            var response = await _client.GetAsync("api/roulette_games/recent").Result.Content.ReadAsStringAsync();

            var blazes = JsonConvert.DeserializeObject<List<Blaze>>(response);

            return blazes;
        }



    }
}
