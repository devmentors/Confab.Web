using System.Threading.Tasks;
using Confab.Web.Core.Clients;

namespace Confab.Web.UI.Services
{
    public interface IApiResponseHandler
    {
        Task<ApiResponse> HandleAsync(Task<ApiResponse> request);
        Task<T> HandleAsync<T>(Task<ApiResponse<T>> request);
    }
}