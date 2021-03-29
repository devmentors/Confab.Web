using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Confab.Web.Core.Clients;
using Confab.Web.Core.DTO;
using Confab.Web.Core.Submissions.Requests;

namespace Confab.Web.Core.Submissions.Services
{
    public class SubmissionService : ISubmissionService
    {
        private const string Path = "agendas-module/submissions";
        private readonly IHttpClient _client;

        public SubmissionService(IHttpClient client)
        {
            _client = client;
        }

        public Task<ApiResponse> CreateAsync(CreateSubmissionRequest request)
            => _client.PostAsync(Path, request);

        public Task<ApiResponse> ApproveAsync(Guid id)
            => _client.PutAsync($"{Path}/{id}/approve", id);

        public Task<ApiResponse> RejectAsync(Guid id)
            => _client.PutAsync($"{Path}/{id}/reject", id);

        public Task<ApiResponse<List<SubmissionDto>>> BrowseAsync(Guid? conferenceId = null, Guid? speakerId = null)
            => _client.GetAsync<List<SubmissionDto>>($"{Path}?conferenceId={conferenceId}&?speakerId={speakerId}");
    }
}