using System;
using System.Collections.Generic;
using System.Text;

namespace MapStory.Core.Entities
{
    public class Group
    {
        
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public virtual ICollection<UserGroup> UserGroups { get; set; }
        public string Pisyun { get; set; }
    }
}

