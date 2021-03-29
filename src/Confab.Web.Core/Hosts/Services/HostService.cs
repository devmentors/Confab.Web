using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Confab.Web.Core.Clients;
using Confab.Web.Core.DTO;
using Confab.Web.Core.Hosts.Requests;

namespace Confab.Web.Core.Hosts.Services
{
    public class HostService : IHostService
    {
        private const string Path = "conferences-module/hosts";
        private readonly IHttpClient _client;

        public HostService(IHttpClient client)
        {
            _client = client;
        }
        
        public Task<ApiResponse<List<HostDto>>> BrowseAsync()
            => _client.GetAsync<List<HostDto>>(Path);
        
        public Task<ApiResponse<HostDto>> GetAsync(Guid id)
            => _client.GetAsync<HostDto>($"{Path}/{id}");

        public Task<ApiResponse> RemoveAsync(Guid id)
            =>  _client.DeleteAsync($"{Path}/{id}");

        public Task<ApiResponse> CreateAsync(CreateHostRequest request)
            => _client.PostAsync(Path, request);
    }
}