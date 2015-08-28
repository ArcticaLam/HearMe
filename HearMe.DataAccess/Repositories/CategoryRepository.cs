using HearMe.DataAccess.Entities;

namespace HearMe.DataAccess.Repositories
{
    public class CategoryRepository : BaseRepository<int, Category>
    {
        public CategoryRepository(HearMeDataContext dataContext) : base(dataContext)
        {
        }
    }
}
