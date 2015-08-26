using System.ComponentModel.DataAnnotations.Schema;

namespace HearMe.DataAccess.Entities.Mapping
{
    internal class ContentLookUpMapping : HearMeBaseMapping<ContentLookup>
    {
        public ContentLookUpMapping()
        {
            Property(x => x.Id).HasColumnName("LookupId").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
    }
}
