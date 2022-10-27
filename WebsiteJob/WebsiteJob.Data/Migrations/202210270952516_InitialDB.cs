namespace WebsiteJob.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Candidates",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Email = c.String(maxLength: 100, fixedLength: true),
                        Phone = c.Int(),
                        Address = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Employers",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        NameEmployers = c.String(maxLength: 250),
                        Email = c.String(maxLength: 100, fixedLength: true),
                        Companyname = c.String(maxLength: 250),
                        Career = c.String(maxLength: 50),
                        Address = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Footers",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 250, unicode: false),
                        Content = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.JobCategories",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 250),
                        Alas = c.String(nullable: false, maxLength: 250, unicode: false),
                        ParentID = c.Int(),
                        Description = c.String(maxLength: 500),
                        DisplayOrder = c.Int(),
                        Image = c.String(maxLength: 500),
                        MetaKeyword = c.String(maxLength: 250),
                        MetaDescription = c.String(maxLength: 250),
                        CreatedDate = c.DateTime(),
                        Createdby = c.String(maxLength: 50, unicode: false),
                        UpdatedDate = c.DateTime(),
                        Updatedby = c.String(maxLength: 50, unicode: false),
                        Status = c.Boolean(nullable: false),
                        HomeFlag = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Jobs",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 250),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Alas = c.String(nullable: false, maxLength: 250, unicode: false),
                        CategoryID = c.Int(nullable: false),
                        Warranty = c.Int(),
                        Content = c.String(),
                        Description = c.String(maxLength: 500),
                        DisplayOrder = c.Int(),
                        MoreImage = c.String(storeType: "xml"),
                        Image = c.String(maxLength: 500),
                        MetaKeyword = c.String(maxLength: 250),
                        MetaDescription = c.String(maxLength: 250),
                        CreatedDate = c.DateTime(),
                        Createdby = c.String(maxLength: 50, unicode: false),
                        UpdatedDate = c.DateTime(),
                        Updatedby = c.String(maxLength: 50, unicode: false),
                        Status = c.Boolean(nullable: false),
                        HomeFlag = c.Boolean(),
                        HotFlag = c.Boolean(),
                        ViewCount = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.JobCategories", t => t.CategoryID)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 50, unicode: false),
                        Name = c.String(maxLength: 50),
                        Type = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 250),
                        Alas = c.String(nullable: false, maxLength: 250, unicode: false),
                        CategoryID = c.Int(nullable: false),
                        Content = c.String(),
                        Description = c.String(maxLength: 500),
                        DisplayOrder = c.Int(),
                        Image = c.String(maxLength: 500),
                        MetaKeyword = c.String(maxLength: 250),
                        MetaDescription = c.String(maxLength: 250),
                        CreatedDate = c.DateTime(),
                        Createdby = c.String(maxLength: 50, unicode: false),
                        UpdatedDate = c.DateTime(),
                        Updatedby = c.String(maxLength: 50, unicode: false),
                        Status = c.Boolean(nullable: false),
                        HomeFlag = c.Boolean(),
                        HotFlag = c.Boolean(),
                        ViewCount = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.PostCategories", t => t.CategoryID)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.PostCategories",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 250),
                        Alas = c.String(nullable: false, maxLength: 250, unicode: false),
                        ParentID = c.Int(),
                        Description = c.String(maxLength: 500),
                        DisplayOrder = c.Int(),
                        Image = c.String(maxLength: 500),
                        MetaKeyword = c.String(maxLength: 250),
                        MetaDescription = c.String(maxLength: 250),
                        CreatedDate = c.DateTime(),
                        Createdby = c.String(maxLength: 50, unicode: false),
                        UpdatedDate = c.DateTime(),
                        Updatedby = c.String(maxLength: 50, unicode: false),
                        Status = c.Boolean(nullable: false),
                        HomeFlag = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.MenuGroup",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Name = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Menu",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Name = c.String(maxLength: 250),
                        URL = c.String(nullable: false, maxLength: 500),
                        DisplayOrder = c.Int(),
                        GroupID = c.Int(nullable: false),
                        Target = c.String(maxLength: 10, unicode: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.MenuGroup", t => t.GroupID)
                .Index(t => t.GroupID);
            
            CreateTable(
                "dbo.Pages",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Name = c.String(maxLength: 250),
                        content = c.String(),
                        MetaKeyword = c.String(maxLength: 250),
                        MetaDescription = c.String(maxLength: 250),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Slides",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Description = c.String(maxLength: 250),
                        Image = c.String(nullable: false, maxLength: 500),
                        URL = c.String(nullable: false, maxLength: 500),
                        DisplayOrder = c.Int(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SupportOnline",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Name = c.String(maxLength: 250),
                        Department = c.String(maxLength: 250),
                        Mobile = c.String(maxLength: 250),
                        Email = c.String(maxLength: 250),
                        Facebook = c.String(maxLength: 250),
                        Status = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.sysdiagrams",
                c => new
                    {
                        diagram_id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 128),
                        principal_id = c.Int(nullable: false),
                        version = c.Int(),
                        definition = c.Binary(),
                    })
                .PrimaryKey(t => t.diagram_id);
            
            CreateTable(
                "dbo.SystemConfigs",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Code = c.String(nullable: false, maxLength: 50, unicode: false),
                        ValueString = c.String(maxLength: 250),
                        ValueInt = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.VisitorStatistics",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        VistedDate = c.DateTime(nullable: false),
                        IPAddress = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PostTags",
                c => new
                    {
                        PostID = c.Int(nullable: false),
                        TagID = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => new { t.PostID, t.TagID })
                .ForeignKey("dbo.Posts", t => t.PostID, cascadeDelete: true)
                .ForeignKey("dbo.Tags", t => t.TagID, cascadeDelete: true)
                .Index(t => t.PostID)
                .Index(t => t.TagID);
            
            CreateTable(
                "dbo.JobTags",
                c => new
                    {
                        JobID = c.Int(nullable: false),
                        TagID = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => new { t.JobID, t.TagID })
                .ForeignKey("dbo.Jobs", t => t.JobID, cascadeDelete: true)
                .ForeignKey("dbo.Tags", t => t.TagID, cascadeDelete: true)
                .Index(t => t.JobID)
                .Index(t => t.TagID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Menu", "GroupID", "dbo.MenuGroup");
            DropForeignKey("dbo.Jobs", "CategoryID", "dbo.JobCategories");
            DropForeignKey("dbo.JobTags", "TagID", "dbo.Tags");
            DropForeignKey("dbo.JobTags", "JobID", "dbo.Jobs");
            DropForeignKey("dbo.PostTags", "TagID", "dbo.Tags");
            DropForeignKey("dbo.PostTags", "PostID", "dbo.Posts");
            DropForeignKey("dbo.Posts", "CategoryID", "dbo.PostCategories");
            DropIndex("dbo.JobTags", new[] { "TagID" });
            DropIndex("dbo.JobTags", new[] { "JobID" });
            DropIndex("dbo.PostTags", new[] { "TagID" });
            DropIndex("dbo.PostTags", new[] { "PostID" });
            DropIndex("dbo.Menu", new[] { "GroupID" });
            DropIndex("dbo.Posts", new[] { "CategoryID" });
            DropIndex("dbo.Jobs", new[] { "CategoryID" });
            DropTable("dbo.JobTags");
            DropTable("dbo.PostTags");
            DropTable("dbo.VisitorStatistics");
            DropTable("dbo.SystemConfigs");
            DropTable("dbo.sysdiagrams");
            DropTable("dbo.SupportOnline");
            DropTable("dbo.Slides");
            DropTable("dbo.Pages");
            DropTable("dbo.Menu");
            DropTable("dbo.MenuGroup");
            DropTable("dbo.PostCategories");
            DropTable("dbo.Posts");
            DropTable("dbo.Tags");
            DropTable("dbo.Jobs");
            DropTable("dbo.JobCategories");
            DropTable("dbo.Footers");
            DropTable("dbo.Employers");
            DropTable("dbo.Candidates");
        }
    }
}
