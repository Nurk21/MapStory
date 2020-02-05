using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace MapStory.Core.Entities
{
    public class Role : IdentityRole<int>
    {
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
