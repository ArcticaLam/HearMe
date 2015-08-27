namespace HearMe.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Blog",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        IsDeactive = c.Boolean(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        CreatedOn = c.DateTime(),
                        UpdateOn = c.DateTime(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.User", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                        IsDeactive = c.Boolean(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        CreatedOn = c.DateTime(),
                        UpdateOn = c.DateTime(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Post",
                c => new
                    {
                        PostId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        PostContent = c.String(),
                        CategoryId = c.Int(nullable: false),
                        IsDeactive = c.Boolean(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        CreatedOn = c.DateTime(),
                        UpdateOn = c.DateTime(),
                    })
                .PrimaryKey(t => t.PostId)
                .ForeignKey("dbo.Category", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Tag",
                c => new
                    {
                        TagId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsDeactive = c.Boolean(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        CreatedOn = c.DateTime(),
                        UpdateOn = c.DateTime(),
                    })
                .PrimaryKey(t => t.TagId);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        IsDeactive = c.Boolean(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        CreatedOn = c.DateTime(),
                        UpdateOn = c.DateTime(),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.CategoryBlog",
                c => new
                    {
                        Category_Id = c.Int(nullable: false),
                        Blog_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Category_Id, t.Blog_Id })
                .ForeignKey("dbo.Category", t => t.Category_Id, cascadeDelete: true)
                .ForeignKey("dbo.Blog", t => t.Blog_Id, cascadeDelete: true)
                .Index(t => t.Category_Id)
                .Index(t => t.Blog_Id);
            
            CreateTable(
                "dbo.PostTag",
                c => new
                    {
                        PostId = c.Int(nullable: false),
                        TagId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.PostId, t.TagId })
                .ForeignKey("dbo.Post", t => t.PostId, cascadeDelete: true)
                .ForeignKey("dbo.Tag", t => t.TagId, cascadeDelete: true)
                .Index(t => t.PostId)
                .Index(t => t.TagId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Blog", "UserId", "dbo.User");
            DropForeignKey("dbo.PostTag", "TagId", "dbo.Tag");
            DropForeignKey("dbo.PostTag", "PostId", "dbo.Post");
            DropForeignKey("dbo.Post", "CategoryId", "dbo.Category");
            DropForeignKey("dbo.CategoryBlog", "Blog_Id", "dbo.Blog");
            DropForeignKey("dbo.CategoryBlog", "Category_Id", "dbo.Category");
            DropIndex("dbo.PostTag", new[] { "TagId" });
            DropIndex("dbo.PostTag", new[] { "PostId" });
            DropIndex("dbo.CategoryBlog", new[] { "Blog_Id" });
            DropIndex("dbo.CategoryBlog", new[] { "Category_Id" });
            DropIndex("dbo.Post", new[] { "CategoryId" });
            DropIndex("dbo.Blog", new[] { "UserId" });
            DropTable("dbo.PostTag");
            DropTable("dbo.CategoryBlog");
            DropTable("dbo.User");
            DropTable("dbo.Tag");
            DropTable("dbo.Post");
            DropTable("dbo.Category");
            DropTable("dbo.Blog");
        }
    }
}
