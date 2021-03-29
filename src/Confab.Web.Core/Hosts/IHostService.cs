using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Confab.Web.Core.Clients;
using Confab.Web.Core.DTO;
using Confab.Web.Core.Hosts.Requests;

namespace Confab.Web.Core.Hosts
{
    public interface IHostService
    {
        Task<ApiResponse<HostDto>> GetAsync(Guid id);
        Task<ApiResponse<List<HostDto>>> BrowseAsync();
        Task<ApiResponse> RemoveAsync(Guid id);
        Task<ApiResponse> CreateAsync(CreateHostRequest request);
    }
}