namespace Confab.Web.Core.Speakers.Requests
{
    public class CreateSpeakerRequest
    {
        public string Email { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
        public string AvatarUrl { get; set; }
    }
}