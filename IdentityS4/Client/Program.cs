using IdentityModel.Client;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace Client
{
    class Program
    {
        static void Main(string[] args) {MainAsync().GetAwaiter().GetResult(); Console.ReadKey();}

        private static async System.Threading.Tasks.Task MainAsync()
        {
            Console.ReadKey();
            //discover endpoints from metadata by calling Auth server
            var discoveryClient = await DiscoveryClient.GetAsync("http://localhost:5000");
            if (discoveryClient.IsError)
            {
                Console.WriteLine(discoveryClient.Error);
                return;
            }

            //request the token from Auth server
            var tokenClient = new TokenClient(discoveryClient.TokenEndpoint,"client","secret");
            var tokenResponse = await tokenClient.RequestClientCredentialsAsync("api1");

            if(tokenResponse.IsError)
            {
                Console.WriteLine(tokenResponse.Error);
                return;
            }

            Console.WriteLine(tokenResponse.Json);

            //call api
            var client = new HttpClient();
            client.SetBearerToken(tokenResponse.AccessToken);

            var response = await client.GetAsync("http://localhost:5001/identity");
            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.StatusCode);
            }
            else
            {
                var content = await response.Content.ReadAsStringAsync();
                Console.WriteLine(JArray.Parse(content));
            }
        }
    }
}
