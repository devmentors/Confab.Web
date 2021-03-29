using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Confab.Web.Core.Clients;
using Confab.Web.Core.Conferences.Requests;
using Confab.Web.Core.DTO;

namespace Confab.Web.Core.Conferences
{
    public interface IConferenceService
    {
        Task<ApiResponse<ConferenceDetailsDto>> GetAsync(Guid id);
        Task<ApiResponse<List<ConferenceDto>>> BrowseAsync();
        Task<ApiResponse> RemoveAsync(Guid id);
        Task<ApiResponse> CreateAsync(CreateConferenceRequest request);
    }
}