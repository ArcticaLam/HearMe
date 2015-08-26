namespace HearMe.DataAccess.Entities.Mapping
{
    internal class TagMapping : HearMeBaseMapping<Tag>
    {
        public TagMapping()
        {
            Property(x => x.Id).HasColumnName("TagId");
        }
    }
}
