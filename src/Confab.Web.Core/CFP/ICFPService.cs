using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Confab.Web.Core.CFP.Requests;
using Confab.Web.Core.Clients;
using Confab.Web.Core.DTO;

namespace Confab.Web.Core.CFP
{
    public interface ICFPService
    {
        Task<ApiResponse> CreateAsync(CreateCFPRequest request);
        Task<ApiResponse> OpenAsync(Guid id);
        Task<ApiResponse> CloseAsync(Guid id);
        Task<ApiResponse<CFPDto>> GetAsync(Guid id);
    }
}