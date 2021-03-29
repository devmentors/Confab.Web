using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Confab.Web.Core.Agendas.Requests;
using Confab.Web.Core.Clients;
using Confab.Web.Core.DTO;

namespace Confab.Web.Core.Agendas
{
    public interface IAgendaTrackService
    {
        // Task<ApiResponse<HostDto>> GetAsync(Guid id);
        Task<ApiResponse<List<AgendaTrackDto>>> BrowseAsync(Guid conferenceId);
        // Task<ApiResponse> RemoveAsync(Guid id);
        Task<ApiResponse> CreateAsync(CreateAgendaTrackRequest request);
    }
}