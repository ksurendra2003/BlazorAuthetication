using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorApp5
{
    public class FacebookHttpClient
    {
        private readonly HttpClient _client;

        public FacebookHttpClient(HttpClient client)
        {
            _client = client;
        }

        public async Task<AutheticatedUser> GetLoggedInUserAsync(string accessToken)
        {
            Console.WriteLine("autheticatedUser------" + accessToken);

            var result = await _client.GetFromJsonAsync<AutheticatedUser>($"me?fields=first_name,last_name,picture&access_token={accessToken}");

            return result;
        }
    }
}
