using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp5.Pages
{
    public class LoginBase : ComponentBase
    {
        [Inject]
        public NavigationManager Navigation { get; set; }

        [Inject]
        public IUserAutheticationService AutheticationService { get; set; }

        [CascadingParameter]
        private Task<AuthenticationState> authenticationStateTask { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            var authState = await authenticationStateTask;

            if (authState.User.Identity.IsAuthenticated)
            {
                Navigation.NavigateTo("Index");
            }
            else
            {
                var url = Navigation.Uri;

                var result = await AutheticationService.LoginUser(url);

                if (result)
                    Navigation.NavigateTo("Index");
            }
        }
        protected override async Task OnInitializedAsync()
        {
            
        }

        protected void LoginWithFacebook()
        {
            Navigation.NavigateTo("https://www.facebook.com/v8.0/dialog/oauth?client_id=2403323079976157&display=popup&response_type=token&redirect_uri=https://autheticationapp.z19.web.core.windows.net/", true);
        }

        protected void LoginWithFacebook1()
        {
            Navigation.NavigateTo("https://localhost:44324/FacebookLogin", true);
        }

        protected void RedirectToIndex()
        {
            Navigation.NavigateTo("Index",true);
        }

    }
}
