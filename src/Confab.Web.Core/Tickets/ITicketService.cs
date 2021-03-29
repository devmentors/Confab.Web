using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Confab.Web.Core.Clients;
using Confab.Web.Core.DTO;
using Confab.Web.Core.Tickets.Requests;

namespace Confab.Web.Core.Tickets
{
    public interface ITicketService
    {
        Task<ApiResponse> CreateAsync(CreateTicketRequest request);
        Task<ApiResponse<List<TicketDto>>> BrowseAsync(Guid id);
        Task<ApiResponse> PurchaseTicket(Guid id);
        Task<ApiResponse<List<TicketResponse>>> BrowsePurchasedTickets();
    }
}