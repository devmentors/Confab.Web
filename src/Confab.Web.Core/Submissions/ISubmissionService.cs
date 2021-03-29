using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Confab.Web.Core.Clients;
using Confab.Web.Core.DTO;
using Confab.Web.Core.Submissions.Requests;

namespace Confab.Web.Core.Submissions
{
    public interface ISubmissionService
    {
        Task<ApiResponse> CreateAsync(CreateSubmissionRequest request);
        Task<ApiResponse> ApproveAsync(Guid id);
        Task<ApiResponse> RejectAsync(Guid id);
        Task<ApiResponse<List<SubmissionDto>>> BrowseAsync(Guid? conferenceId = null, Guid? speakerId = null);
    }
}