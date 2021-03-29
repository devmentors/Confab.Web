using System;
using System.Threading.Tasks;
using Confab.Web.Core.Clients;
using Confab.Web.Core.DTO;
using Confab.Web.Core.Speakers.Requests;

namespace Confab.Web.Core.Speakers.Services
{
    class SpeakerService : ISpeakerService
    {
        private const string Path = "speakers-module/speakers";
        private readonly IHttpClient _client;

        public SpeakerService(IHttpClient client)
        {
            _client = client;
        }
        
        public Task<ApiResponse> CreateAsync(CreateSpeakerRequest request)
            => _client.PostAsync(Path, request);
        
        public Task<ApiResponse<SpeakerDto>> GetAsync(Guid id)
            => _client.GetAsync<SpeakerDto>($"{Path}/{id}");
    }
}