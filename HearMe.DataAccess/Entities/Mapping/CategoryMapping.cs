namespace HearMe.DataAccess.Entities.Mapping
{
    internal class CategoryMapping : BaseMapping<int, Category>
    {
        public CategoryMapping()
        {
            Property(x => x.Id).HasColumnName("CategoryId");
        }
    }
}
