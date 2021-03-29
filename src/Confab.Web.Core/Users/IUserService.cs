using System;
using System.Threading.Tasks;
using Confab.Web.Core.Clients;
using Confab.Web.Core.DTO;
using Confab.Web.Core.Users.DTO;
using Confab.Web.Core.Users.Requests;

namespace Confab.Web.Core.Users
{
    public interface IUserService
    {
        Task<ApiResponse<UserDetailsDto>> GetAsync();
        Task<ApiResponse> SignUpAsync(SignUpRequest request);
        Task<ApiResponse<AuthDto>> SignInAsync(SignInRequest request);
    }
}