using HearMe.DataAccess.Entities;

namespace HearMe.DataAccess.Repositories
{
    public class TagRepository : BaseRepository<int, Tag>
    {
        public TagRepository(HearMeDataContext dataContext) : base(dataContext)
        {
        }
    }
}
