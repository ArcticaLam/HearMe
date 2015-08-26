namespace HearMe.DataAccess.Entities.Mapping
{
    internal class MediaContentMapping : HearMeBaseMapping<MediaContent>
    {
        public MediaContentMapping()
        {
            HasRequired(x => x.Post).WithMany(x => x.MediaContents).HasForeignKey(x => x.PostId);
            HasRequired(x => x.ContentLookup);   

        }
    }
}
