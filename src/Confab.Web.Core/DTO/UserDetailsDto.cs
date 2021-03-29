using System;
using System.Collections.Generic;

namespace Confab.Web.Core.DTO
{
    public class UserDetailsDto : UserDto
    {
        public string Email { get; set; }
        public string Role { get; set; }
        public Dictionary<string, IEnumerable<string>> Claims { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}