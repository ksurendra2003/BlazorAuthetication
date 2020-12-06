using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Blazored.LocalStorage;

namespace BlazorApp5
{
    public interface IUserAutheticationService
    {
        Task<ClaimsPrincipal> GetCurrentUserPrincipal();
        Task<bool> LoginUser(string callbackUrl);
        Task<bool> LogOutUser();
    }

    public class UserAutheticationService : IUserAutheticationService
    {
        private Task<AuthenticationState> _currentAuthenticationStateTask;

        private readonly AuthenticationStateProvider _authenticationStateProvider;

        public UserAutheticationService(AuthenticationStateProvider authenticationStateProvider)
        {
            _authenticationStateProvider = authenticationStateProvider;
            _authenticationStateProvider.AuthenticationStateChanged += OnAuthenticationStateChanged;
        }

        private void OnAuthenticationStateChanged(Task<AuthenticationState> task)
        {
            _currentAuthenticationStateTask = task;
        }

        public async Task<ClaimsPrincipal> GetCurrentUserPrincipal()
        {
            var state = await _currentAuthenticationStateTask;
            return state.User;
        }

        public Task<bool> LoginUser(string callbackUrl)
        {
            return ((IApiAuthenticationStateProvider)_authenticationStateProvider).LoginUserAsync(callbackUrl);
        }

        public Task<bool> LogOutUser()
        {
            return ((IApiAuthenticationStateProvider)_authenticationStateProvider).LogOutUserAsync();
        }

    }
}
