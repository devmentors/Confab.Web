using System;

namespace Confab.Web.Core.DTO
{
    public class SpeakerDto
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
        public string AvatarUrl { get; set; }
    }
}