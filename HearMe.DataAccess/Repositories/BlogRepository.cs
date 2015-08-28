using HearMe.DataAccess.Entities;

namespace HearMe.DataAccess.Repositories
{
    public class BlogRepository : BaseRepository<int, Blog>
    {
        public BlogRepository(HearMeDataContext dataContext) : base(dataContext)
        {
        }
    }
}
