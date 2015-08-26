using System.Collections.Generic;

namespace HearMe.DataAccess.Entities
{
    public class Category : HearMeBaseEntity
    {
        public string CategoryName { get; set; }

        public virtual IList<Blog> Blogs { get; set; }
        public virtual IList<Post> Posts { get; set; }
    }
}
