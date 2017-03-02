using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RestComXamarin.Models
{
    public class Repository
    {
        public async Task<List<Cat>> GetCats()
        {
            List<Cat> Cats;

            var URLWebApi = "http://demos.ticapacitacion.com/cats";
            using (var client = new System.Net.Http.HttpClient())
            {
                var JSON = await client.GetStringAsync(URLWebApi);
                Cats = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Cat>>(JSON);
            }
            return Cats;

        }
    }
}
