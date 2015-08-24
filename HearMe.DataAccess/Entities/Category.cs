using System.Collections.Generic;

namespace HearMe.DataAccess.Entities
{
    public class Category : BaseEntity
    {
        public string Title { get; set; }

        public virtual IList<Post> Posts { get; set; }
    }
}
