namespace HearMe.DataAccess.Entities.Mapping
{
    internal class PostMapping : BaseMapping<int, Post>
    {
        public PostMapping()
        {
            Property(x => x.Id).HasColumnName("PostId");
            HasRequired(x => x.Category).WithMany(x => x.Posts).HasForeignKey(x => x.CategoryId);
            HasMany(x => x.Tags).WithMany(x => x.Posts).Map(x =>
            {
                x.ToTable("PostTag");
                x.MapLeftKey("PostId");
                x.MapRightKey("TagId");
            });
        }
    }
}
