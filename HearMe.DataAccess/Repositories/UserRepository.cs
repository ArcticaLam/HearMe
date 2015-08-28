using HearMe.DataAccess.Entities;

namespace HearMe.DataAccess.Repositories
{
    public class UserRepository : BaseRepository<int, User>
    {
        public UserRepository(HearMeDataContext dataContext) : base(dataContext)
        {
        }
    }
}
