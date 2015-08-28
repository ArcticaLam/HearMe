using HearMe.DataAccess.Entities;

namespace HearMe.DataAccess.Repositories
{
    public class ContentLookUpRepository : BaseRepository<int, ContentLookup>
    {
        public ContentLookUpRepository(HearMeDataContext dataContext) : base(dataContext)
        {
        }
    }
}
