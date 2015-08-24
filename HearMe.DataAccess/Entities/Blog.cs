using System.Collections.Generic;

namespace HearMe.DataAccess.Entities
{
    public class Blog : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        //public int UserId { get; set; }

        public virtual User User { get; set; }
        public virtual IList<Category> Categories { get; set; }
    }
}
