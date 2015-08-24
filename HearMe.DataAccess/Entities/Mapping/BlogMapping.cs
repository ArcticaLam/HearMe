namespace HearMe.DataAccess.Entities.Mapping
{
    internal class BlogMapping:BaseMapping<Blog>
    {
        internal BlogMapping()
        {
            HasRequired(x => x.User).WithRequiredDependent(x => x.Blog);
        }
    }
}
