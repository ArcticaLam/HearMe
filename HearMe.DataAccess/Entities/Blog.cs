using System.Collections.Generic;

namespace HearMe.DataAccess.Entities
{
    public class Blog : HearMeBaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public virtual User User { get; set; }
        public virtual IList<Category> Categories { get; set; }
    }
}
