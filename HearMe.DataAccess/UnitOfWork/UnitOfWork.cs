namespace HearMe.DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private HearMeDataContext context;

        public UnitOfWork(HearMeDataContext dataContext)
        {
            context = dataContext;
        }

        public void Commit()
        {
            context.SaveChanges();
        }
    }
}
