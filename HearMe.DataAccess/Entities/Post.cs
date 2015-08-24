using System.Collections.Generic;

namespace HearMe.DataAccess.Entities
{
    public class Post
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual IList<Tag> Tags { get; set; }

    }
}
