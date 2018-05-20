using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using LuisDelValle.Calculator.Abstractions;
using LuisDelValle.Calculator.CalculatorService.Models;
using Newtonsoft.Json;

namespace LuisDelValle.Calculator.WebApp.Services
{
    public class RestClient : IRestClient
    {
        public string Host { get; set; }
        public string Path { get; set; }

        private static HttpClient Client = new HttpClient();

        public async Task<Response> GetResponseAsync()
        {
            var stringResponse = await Client.GetStringAsync(Host + Path);

            if (stringResponse != null)
            {
                SequencesResponse sequenceResponse = JsonConvert.DeserializeObject<SequencesResponse>(stringResponse);

                if (sequenceResponse != null)
                {
                    return sequenceResponse;
                }
            }

            return null;
        }
    }
}
