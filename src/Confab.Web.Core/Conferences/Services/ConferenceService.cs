using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Confab.Web.Core.Clients;
using Confab.Web.Core.Conferences.Requests;
using Confab.Web.Core.DTO;

namespace Confab.Web.Core.Conferences.Services
{
    internal class ConferenceService : IConferenceService
    {
        private const string Path = "conferences-module/conferences";
        private readonly IHttpClient _client;

        public ConferenceService(IHttpClient client)
        {
            _client = client;
        }
        
        public Task<ApiResponse<ConferenceDetailsDto>> GetAsync(Guid id)
            => _client.GetAsync<ConferenceDetailsDto>($"{Path}/{id}");

        public Task<ApiResponse<List<ConferenceDto>>> BrowseAsync()
            => _client.GetAsync<List<ConferenceDto>>(Path);

        public Task<ApiResponse> RemoveAsync(Guid id)
            =>  _client.DeleteAsync($"{Path}/{id}");

        public Task<ApiResponse> CreateAsync(CreateConferenceRequest request)
            => _client.PostAsync(Path, request);
    }
}