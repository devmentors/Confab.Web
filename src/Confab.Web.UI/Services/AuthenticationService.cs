using System.Net;
using System.Threading.Tasks;
using Confab.Web.Core.Models;
using Confab.Web.Core.Storage;
using Confab.Web.Core.Users;
using Confab.Web.Core.Users.Requests;
using Microsoft.AspNetCore.Components;

namespace Confab.Web.UI.Services
{
    internal class AuthenticationService : IAuthenticationService
    {
        private readonly IUserService _userService;
        private readonly ILocalStorageService _localStorageService;
        private readonly NavigationManager _navigationManager;

        public User User { get; private set; }

        public AuthenticationService(IUserService userService, ILocalStorageService localStorageService,
            NavigationManager navigationManager)
        {
            _userService = userService;
            _localStorageService = localStorageService;
            _navigationManager = navigationManager;
        }

        public async Task InitializeAsync()
        {
            User = await _localStorageService.GetItemAsync<User>("user");
        }

        public async Task<bool?> SignInAsync(string email, string password)
        {
            var response = await _userService.SignInAsync(new SignInRequest
            {
                Email = email,
                Password = password
            });

            if (response?.HttpResponse is null)
            {
                return null;
            }

            if (!response.Succeeded)
            {
                return false;
            }

            User = new User
            {
                Id = response.Value.Id,
                Email = response.Value.Email,
                Role = response.Value.Role,
                AccessToken = response.Value.AccessToken,
                RefreshToken = response.Value.RefreshToken,
                Expires = response.Value.Expires
            };
            await _localStorageService.SetItemAsync("user", User);

            return true;
        }

        public async Task SignOutAsync()
        {
            User = null;
            await _localStorageService.RemoveItemAsync("user");
            _navigationManager.NavigateTo("sign-in");
        }
    }
}