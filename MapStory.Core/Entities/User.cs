using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MapStory.Core.Entities
{
    public class User: IdentityUser<int>
    {
        public DateTime DateOfBirth { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime LastActive { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<UserGroup> UserGroups { get; set; }
    }
}
