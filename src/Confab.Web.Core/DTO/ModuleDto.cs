using System.Collections.Generic;

namespace Confab.Web.Core.DTO
{
    public class ModuleDto
    {
        public string Name { get; set; }
        public IEnumerable<string> Policies { get; set; }
    }
}