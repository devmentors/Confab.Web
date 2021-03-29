using System;
using System.Threading.Tasks;
using Confab.Web.Core.CFP.Requests;
using Confab.Web.Core.Clients;
using Confab.Web.Core.DTO;

namespace Confab.Web.Core.CFP.Services
{
    class CFPService : ICFPService
    {
        private const string Path = "agendas-module/conferences";
        private readonly IHttpClient _client;

        public CFPService(IHttpClient client)
        {
            _client = client;
        }
        public Task<ApiResponse> CreateAsync(CreateCFPRequest request)
            => _client.PostAsync($"{Path}/{request.ConferenceId}/cfp", request);
            
        public Task<ApiResponse> OpenAsync(Guid id)
            => _client.PutAsync($"{Path}/{id}/cfp/open", id);
            
        public Task<ApiResponse> CloseAsync(Guid id)
            => _client.PutAsync($"{Path}/{id}/cfp/close", id);

        public Task<ApiResponse<CFPDto>> GetAsync(Guid id)
            => _client.GetAsync<CFPDto>($"{Path}/{id}/cfp");
    }
}