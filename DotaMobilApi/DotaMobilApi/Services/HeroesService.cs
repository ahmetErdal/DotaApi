using DotaMobilApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DotaMobilApi.Services
{
    public class HeroesService : IHeroesService
    {
        string Base_url = "https://api.opendota.com/api/heroStats";
        public async Task<ObservableCollection<HeroesStat>> getHeroes()
        {
            string url = Base_url;

            HttpClient client = new HttpClient();
            HttpResponseMessage responseMessage = await client.GetAsync(url);

            if (responseMessage.StatusCode==System.Net.HttpStatusCode.OK)
            {
                var result = await responseMessage.Content.ReadAsStringAsync();
                var json = JsonConvert.DeserializeObject<ObservableCollection<HeroesStat>>(result);

                return json;
            }
            return null;
        }
    }
}
