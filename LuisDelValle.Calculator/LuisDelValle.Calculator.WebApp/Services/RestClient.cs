using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using IdentityModel.Client;
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

        private async Task RequestTokenAsync()
        {
            // discover endpoints from metadata
            var disco = await DiscoveryClient.GetAsync("http://localhost:5000/");
            if (disco.IsError)
            {
                Console.WriteLine(disco.Error);
                return;
            }

            // request token
            var tokenClient = new TokenClient(disco.TokenEndpoint, "client", "secret");
            var tokenResponse = await tokenClient.RequestClientCredentialsAsync("sequencesapi");

            if (tokenResponse.IsError)
            {
                Console.WriteLine(tokenResponse.Error);
                return;
            }

            Client.SetBearerToken(tokenResponse.AccessToken);
            return;
        }

        public async Task<Abstractions.Response> GetResponseAsync()
        {
            await RequestTokenAsync();

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
