using System;

namespace Confab.Web.Core.DTO
{
    public class CFPDto
    {
        public Guid Id { get; set; }
        public Guid ConferenceId { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public bool IsOpened { get; set; }
    }
}