using System;
using System.Collections.Generic;
using System.Text;

namespace MapStory.Core.Entities
{
    public class UserGroup
    {
        public virtual Guid GroupId { get; set; }
        public virtual Group Group { get; set; }
        public virtual int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
