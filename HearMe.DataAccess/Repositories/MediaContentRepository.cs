using HearMe.DataAccess.Entities;

namespace HearMe.DataAccess.Repositories
{
    public class MediaContentRepository : BaseRepository<int, MediaContent>
    {
        public MediaContentRepository(HearMeDataContext dataContext) : base(dataContext)
        {
        }
    }
}
