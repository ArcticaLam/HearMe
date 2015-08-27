namespace HearMe.DataAccess.Entities.Mapping
{
    internal class TagMapping : BaseMapping<int, Tag>
    {
        public TagMapping()
        {
            Property(x => x.Id).HasColumnName("TagId");
        }
    }
}
