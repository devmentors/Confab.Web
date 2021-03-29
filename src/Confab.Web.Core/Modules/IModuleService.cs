using System.Collections.Generic;
using System.Threading.Tasks;
using Confab.Web.Core.Clients;
using Confab.Web.Core.DTO;

namespace Confab.Web.Core.Modules
{
    public interface IModuleService
    {
        Task<ApiResponse<List<ModuleDto>>> BrowseAsync();
    }
}