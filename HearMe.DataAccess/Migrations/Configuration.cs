using System;
using System.Data.Entity.Migrations;
using HearMe.DataAccess.Entities;

namespace HearMe.DataAccess.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<HearMeDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HearMeDataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.ContentLookups.AddOrUpdate(x => x.Id,
                new ContentLookup { Id = 1, LookupName = "Image", CreatedOn = DateTime.Now }, new ContentLookup { Id = 2, LookupName = "Music", CreatedOn = DateTime.Now });
        }
    }
}
