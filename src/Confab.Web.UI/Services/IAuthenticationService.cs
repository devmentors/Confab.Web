using System.Threading.Tasks;
using Confab.Web.Core.Models;

namespace Confab.Web.UI.Services
{
    public interface IAuthenticationService
    {
        User User { get; }
        Task InitializeAsync();
        Task<bool?> SignInAsync(string email, string password);
        Task SignOutAsync();
    }
}