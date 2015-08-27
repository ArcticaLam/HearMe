using System.Collections.Generic;

namespace HearMe.DataAccess.Entities
{
    public class Post : BaseEntity<int>
    {
        public string Title { get; set; }
        public string PostContent { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual IList<Tag> Tags { get; set; }
        public virtual IList<MediaContent> MediaContents { get; set; }

    }
}
