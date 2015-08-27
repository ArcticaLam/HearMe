namespace HearMe.DataAccess.Entities.Mapping
{
    internal class MediaContentMapping : BaseMapping<int, MediaContent>
    {
        public MediaContentMapping()
        {
            HasRequired(x => x.Post).WithMany(x => x.MediaContents).HasForeignKey(x => x.PostId);
            HasRequired(x => x.ContentLookup);   

        }
    }
}
