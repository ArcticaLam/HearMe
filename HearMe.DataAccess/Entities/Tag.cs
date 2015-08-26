using System.Collections.Generic;

namespace HearMe.DataAccess.Entities
{
    public class Tag : HearMeBaseEntity
    {
        public string Name { get; set; }

        public virtual IList<Post> Posts { get; set; }
    }
}
