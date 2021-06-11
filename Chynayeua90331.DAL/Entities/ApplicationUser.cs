using Microsoft.AspNetCore.Identity;

namespace Chynayeua90331.DAL.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public byte[] AvatarImage { get; set; }
    }
}
