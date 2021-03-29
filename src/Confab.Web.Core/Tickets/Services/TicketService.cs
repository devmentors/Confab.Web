using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Confab.Web.Core.Clients;
using Confab.Web.Core.DTO;
using Confab.Web.Core.Tickets.Requests;

namespace Confab.Web.Core.Tickets.Services
{
    internal class TicketService : ITicketService
    {
        private const string SalesPath = "tickets-module/sales/conferences";
        private const string TicketsPath = "tickets-module/tickets/conferences";
        private const string PurchasedTicketsPath = "tickets-module/tickets";
        private readonly IHttpClient _client;

        public TicketService(IHttpClient client)
        {
            _client = client;
        }
        
        public Task<ApiResponse> CreateAsync(CreateTicketRequest request)
            => _client.PostAsync($"{SalesPath}/{request.ConferenceId}", request);

        public Task<ApiResponse<List<TicketDto>>> BrowseAsync(Guid id)
            => _client.GetAsync<List<TicketDto>>($"{SalesPath}/{id}");

        public Task<ApiResponse> PurchaseTicket(Guid id)
            => _client.PostAsync($"{TicketsPath}/{id}/purchase", id);

        public Task<ApiResponse<List<TicketResponse>>> BrowsePurchasedTickets()
            => _client.GetAsync<List<TicketResponse>>($"{PurchasedTicketsPath}");
    }
}