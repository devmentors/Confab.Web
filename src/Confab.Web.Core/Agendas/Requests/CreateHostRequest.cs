using System;

namespace Confab.Web.Core.Agendas.Requests
{
    public class CreateAgendaTrackRequest
    {
        public Guid ConferenceId { get; set; }
        public string Name { get; set; }
    }
}