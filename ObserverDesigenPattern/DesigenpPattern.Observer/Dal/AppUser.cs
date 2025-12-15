using Microsoft.AspNetCore.Identity;

namespace DesigenpPattern.Observer.Dal
{
    public class AppUser : IdentityUser<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? City { get; set; }
        public string? District  { get; set; }
    }
}
