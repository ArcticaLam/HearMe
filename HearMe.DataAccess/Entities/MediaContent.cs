namespace HearMe.DataAccess.Entities
{
    public class MediaContent : BaseEntity<int>
    {
        public string ContentPhysicalPath { get; set; }
        public int ContentTypeId { get; set; }
        public int PostId { get; set; }

        public virtual ContentLookup ContentLookup { get; set; }
        public virtual Post Post { get; set; }
    }
}
