using System;

namespace Confab.Web.Core.Conferences.Requests
{
    public class CreateConferenceRequest
    {
        public Guid HostId { get; set; }
        public string Name { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public int? ParticipantsLimit { get; set; }
        public string? LogoUrl { get; set; }
    }
}