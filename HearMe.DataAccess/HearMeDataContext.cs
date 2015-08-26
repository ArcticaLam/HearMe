using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using HearMe.DataAccess.Entities;

namespace HearMe.DataAccess
{
    public class HearMeDataContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ContentLookup> ContentLookups { get; set; }
        public DbSet<MediaContent> MediaContents { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }

        public HearMeDataContext()
            : base("name=HearMeConnectionString")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<HearMeDataContext>());
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(typeof(HearMeDataContext).Assembly);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
