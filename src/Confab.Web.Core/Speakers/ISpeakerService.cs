using System;
using System.Threading.Tasks;
using Confab.Web.Core.Clients;
using Confab.Web.Core.DTO;
using Confab.Web.Core.Speakers.Requests;

namespace Confab.Web.Core.Speakers
{
    public interface ISpeakerService
    {
        Task<ApiResponse> CreateAsync(CreateSpeakerRequest request);
        Task<ApiResponse<SpeakerDto>> GetAsync(Guid id);
    }
}