using System.Collections.Generic;
using System.Threading.Tasks;
using Confab.Web.Core.Clients;
using Confab.Web.Core.DTO;

namespace Confab.Web.Core.Modules.Services
{
    internal class ModuleService : IModuleService
    {
        private const string Path = "modules";
        private readonly IHttpClient _client;

        public ModuleService(IHttpClient client)
        {
            _client = client;
        }
        
        public Task<ApiResponse<List<ModuleDto>>> BrowseAsync()
            => _client.GetAsync<List<ModuleDto>>(Path);
    }
}