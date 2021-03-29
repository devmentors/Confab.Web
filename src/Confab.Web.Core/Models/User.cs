namespace Confab.Web.Core.Models
{
    public class User
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public long Expires { get; set; }
        public bool IsAdmin => Role == "admin";
    }
}