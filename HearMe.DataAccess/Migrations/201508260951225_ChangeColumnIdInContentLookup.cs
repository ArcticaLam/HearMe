namespace HearMe.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeColumnIdInContentLookup : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MediaContent", "ContentLookup_Id", "dbo.ContentLookup");
            DropPrimaryKey("dbo.ContentLookup");
            AlterColumn("dbo.ContentLookup", "LookupId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.ContentLookup", "LookupId");
            AddForeignKey("dbo.MediaContent", "ContentLookup_Id", "dbo.ContentLookup", "LookupId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MediaContent", "ContentLookup_Id", "dbo.ContentLookup");
            DropPrimaryKey("dbo.ContentLookup");
            AlterColumn("dbo.ContentLookup", "LookupId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.ContentLookup", "LookupId");
            AddForeignKey("dbo.MediaContent", "ContentLookup_Id", "dbo.ContentLookup", "LookupId", cascadeDelete: true);
        }
    }
}
