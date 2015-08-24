using System.Data.Entity;
using HearMe.DataAccess.Entities;

namespace HearMe.DataAccess
{
    public class HearMeDataContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<User> Users { get; set; }

        public HearMeDataContext()
            : base("name=HearMeConnectionString")
        {
            
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(typeof(HearMeDataContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
