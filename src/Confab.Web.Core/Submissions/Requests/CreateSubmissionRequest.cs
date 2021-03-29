using System;
using System.Collections.Generic;

namespace Confab.Web.Core.Submissions.Requests
{
    public class CreateSubmissionRequest
    {
        public Guid ConferenceId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Level { get; set; }
        public string Status { get; set; }
        public IEnumerable<string> Tags { get; set; }
        public IEnumerable<Guid> SpeakerIds { get; set; }
    }
}