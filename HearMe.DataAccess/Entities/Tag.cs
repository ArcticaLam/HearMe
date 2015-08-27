using System.Collections.Generic;

namespace HearMe.DataAccess.Entities
{
    public class Tag : BaseEntity<int>
    {
        public string Name { get; set; }

        public virtual IList<Post> Posts { get; set; }
    }
}
