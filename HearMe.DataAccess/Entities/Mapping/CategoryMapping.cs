namespace HearMe.DataAccess.Entities.Mapping
{
    internal class CategoryMapping : HearMeBaseMapping<Category>
    {
        public CategoryMapping()
        {
            Property(x => x.Id).HasColumnName("CategoryId");
        }
    }
}
