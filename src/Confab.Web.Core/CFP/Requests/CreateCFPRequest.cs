using System;

namespace Confab.Web.Core.CFP.Requests
{
    public class CreateCFPRequest
    {
        public Guid ConferenceId { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}