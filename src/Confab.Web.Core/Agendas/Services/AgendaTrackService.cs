using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Confab.Web.Core.Agendas.Requests;
using Confab.Web.Core.Clients;
using Confab.Web.Core.DTO;

namespace Confab.Web.Core.Agendas.Services
{
    public class AgendaTrackService : IAgendaTrackService
    {
        private const string Path = "agendas-module/agendas";
        private readonly IHttpClient _client;

        public AgendaTrackService(IHttpClient client)
        {
            _client = client;
        }
        
        public Task<ApiResponse<List<AgendaTrackDto>>> BrowseAsync(Guid conferenceId)
            => _client.GetAsync<List<AgendaTrackDto>>($"{Path}/{conferenceId}");
        //
        // public Task<ApiResponse<HostDto>> GetAsync(Guid id)
        //     => _client.GetAsync<HostDto>($"{Path}/{id}");
        //
        // public Task<ApiResponse> RemoveAsync(Guid id)
        //     =>  _client.DeleteAsync($"{Path}/{id}");

        public Task<ApiResponse> CreateAsync(CreateAgendaTrackRequest request)
            => _client.PostAsync($"{Path}/{request.ConferenceId}/tracks", request);
    }
}