using System;
using System.Threading.Tasks;
using Confab.Web.Core.Clients;
using Confab.Web.Core.DTO;
using Confab.Web.Core.Users.DTO;
using Confab.Web.Core.Users.Requests;

namespace Confab.Web.Core.Users.Services
{
    internal class UserService : IUserService
    {
        private readonly IHttpClient _client;

        public UserService(IHttpClient client)
        {
            _client = client;
        }

        public Task<ApiResponse<UserDetailsDto>> GetAsync()
            => _client.GetAsync<UserDetailsDto>("users-module/account");

        public Task<ApiResponse> SignUpAsync(SignUpRequest request)
            => _client.PostAsync("users-module/account/sign-up", request);

        public Task<ApiResponse<AuthDto>> SignInAsync(SignInRequest request)
            => _client.PostAsync<AuthDto>("users-module/account/sign-in", request);
    }
}