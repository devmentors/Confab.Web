namespace Confab.Web.Core.Users.Requests
{
    public class SignUpRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public Claims Claims { get; set; }
    }
}