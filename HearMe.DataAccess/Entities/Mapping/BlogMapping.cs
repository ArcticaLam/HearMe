namespace HearMe.DataAccess.Entities.Mapping
{
    internal class BlogMapping : BaseMapping<int, Blog>
    {
        internal BlogMapping()
        {
            Property(x => x.Id).HasColumnName("UserId");
            HasRequired(x => x.User).WithRequiredDependent(x => x.Blog);
        }
    }
}
