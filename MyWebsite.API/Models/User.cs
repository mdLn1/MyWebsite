using Microsoft.AspNetCore.Identity;

namespace MyWebsite.API.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
    }
}