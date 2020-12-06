using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BlazorApp5
{
    public interface IApiAuthenticationStateProvider
    {
        Task<bool> LoginUserAsync(string callbackUrl);
        Task<bool> LogOutUserAsync();
    }

    public class CustomAuthenticationStateProvider : AuthenticationStateProvider, IApiAuthenticationStateProvider
    {
        private readonly FacebookHttpClient _httpClient;
        private readonly ILocalStorageService _localStorageService;

        private const string AccessToken = "access_token";
        public CustomAuthenticationStateProvider(FacebookHttpClient httpClient, ILocalStorageService localStorageService)
        {
            _httpClient = httpClient;
            _localStorageService = localStorageService;
        }
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            try
            {
                var accessToken = await _localStorageService.GetItemAsStringAsync(AccessToken);

                if (!string.IsNullOrWhiteSpace(accessToken))
                {
                    var autheticatedUser = await _httpClient.GetLoggedInUserAsync(accessToken);

                    Console.WriteLine("autheticatedUser.First_Name)--autheticatedUser.First_Name) ---" + autheticatedUser.First_Name);

                    var identity = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, autheticatedUser.FullName) }, " authentication type");

                    var user = new ClaimsPrincipal(identity);

                    return new AuthenticationState(user);
                }
                else
                {
                    var authenticationState = new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));

                    return authenticationState;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("GetLoggedInUserAsync exception --" + ex.ToString());

                var authenticationState = new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));

                return authenticationState;

            }
        }

        public async Task<bool> LoginUserAsync(string callbackUrl)
        {
            var startIndex = callbackUrl.IndexOf("access_token=");

            if (startIndex > 0)
            {
                var endIndex = callbackUrl.IndexOf("&data_access_expiration_time");

                var accessToken = callbackUrl.Substring(startIndex, endIndex);

                accessToken = accessToken.Replace("access_token=", "");

                accessToken = accessToken.Replace("&data_access_expiration_t", "");

                await _localStorageService.SetItemAsync<string>("access_token", accessToken);

                var authenticationState = await GetAuthenticationStateAsync();

                NotifyAuthenticationStateChanged(Task.FromResult(authenticationState));
                return true;
            }

            return false;
        }

        public async Task<bool> LogOutUserAsync()
        {
            await _localStorageService.RemoveItemAsync(AccessToken);

            var authenticationState = await GetAuthenticationStateAsync();

            NotifyAuthenticationStateChanged(Task.FromResult(authenticationState));

            return true;
        }
    }
}
