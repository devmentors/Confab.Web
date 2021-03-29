using System;

namespace Confab.Web.Core.Tickets.Requests
{
    public class CreateTicketRequest
    {
        public Guid ConferenceId { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public decimal? Amount { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}