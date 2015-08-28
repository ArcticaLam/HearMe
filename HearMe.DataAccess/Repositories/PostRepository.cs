using HearMe.DataAccess.Entities;

namespace HearMe.DataAccess.Repositories
{
    public class PostRepository : BaseRepository<int, Post>
    {
        public PostRepository(HearMeDataContext dataContext) : base(dataContext)
        {
        }
    }
}
