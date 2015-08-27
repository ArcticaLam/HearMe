namespace HearMe.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Additional_Table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MediaContent",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ContentPhysicalPath = c.String(),
                        ContentTypeId = c.Int(nullable: false),
                        PostId = c.Int(nullable: false),
                        IsDeactive = c.Boolean(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        CreatedOn = c.DateTime(),
                        UpdateOn = c.DateTime(),
                        ContentLookup_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ContentLookup", t => t.ContentLookup_Id, cascadeDelete: true)
                .ForeignKey("dbo.Post", t => t.PostId, cascadeDelete: true)
                .Index(t => t.PostId)
                .Index(t => t.ContentLookup_Id);
            
            CreateTable(
                "dbo.ContentLookup",
                c => new
                    {
                        LookupId = c.Int(nullable: false, identity: true),
                        LookupName = c.String(),
                        IsDeactive = c.Boolean(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        CreatedOn = c.DateTime(),
                        UpdateOn = c.DateTime(),
                    })
                .PrimaryKey(t => t.LookupId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MediaContent", "PostId", "dbo.Post");
            DropForeignKey("dbo.MediaContent", "ContentLookup_Id", "dbo.ContentLookup");
            DropIndex("dbo.MediaContent", new[] { "ContentLookup_Id" });
            DropIndex("dbo.MediaContent", new[] { "PostId" });
            DropTable("dbo.ContentLookup");
            DropTable("dbo.MediaContent");
        }
    }
}
