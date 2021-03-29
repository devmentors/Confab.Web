using System;

namespace Confab.Web.Core.DTO
{
    public class TicketDto
    {
        public string Name { get; set; }
        public Conference Conference { get; set; }
        public int? TicketPrice { get; set; }
        public int TotalTickets { get; set; }
        public int AvailableTickets { get; set; }
        public DateTime SaleFrom { get; set; }
        public DateTime SaleTo { get; set; }
        public bool IsFree { get; set; }
        public bool UnlimitedTickets { get; set; }
        public bool IsAvailable { get; set; }
    }
    
    public class Conference
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
