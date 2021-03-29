using Confab.Web.Core.Agendas;
using Confab.Web.Core.Agendas.Services;
using Confab.Web.Core.CFP;
using Confab.Web.Core.CFP.Services;
using Confab.Web.Core.Clients;
using Confab.Web.Core.Conferences;
using Confab.Web.Core.Conferences.Services;
using Confab.Web.Core.Hosts;
using Confab.Web.Core.Hosts.Services;
using Confab.Web.Core.Modules;
using Confab.Web.Core.Modules.Services;
using Confab.Web.Core.Speakers;
using Confab.Web.Core.Speakers.Services;
using Confab.Web.Core.Storage;
using Confab.Web.Core.Submissions;
using Confab.Web.Core.Submissions.Services;
using Confab.Web.Core.Tickets;
using Confab.Web.Core.Tickets.Services;
using Confab.Web.Core.Users;
using Confab.Web.Core.Users.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Confab.Web.Core
{
    public static class Extensions
    {
        public static IServiceCollection AddCore(this IServiceCollection services)
        {
            services.AddScoped<IHttpClient, CustomHttpClient>();
            services.AddScoped<ILocalStorageService, LocalStorageService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IConferenceService, ConferenceService>();
            services.AddScoped<IHostService, HostService>();
            services.AddScoped<IModuleService, ModuleService>();
            services.AddScoped<ITicketService, TicketService>();
            services.AddScoped<ICFPService, CFPService>();
            services.AddScoped<ISubmissionService, SubmissionService>();
            services.AddScoped<ISpeakerService, SpeakerService>();
            services.AddScoped<IAgendaTrackService, AgendaTrackService>();

            return services;
        }
    }
}