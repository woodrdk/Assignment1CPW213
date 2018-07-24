namespace Assignment1CPW213.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SiteNam : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Information",
                c => new
                    {
                        SourceID = c.Int(nullable: false, identity: true),
                        SiteName = c.String(nullable: false, maxLength: 40),
                        URL = c.String(nullable: false, maxLength: 40),
                    })
                .PrimaryKey(t => t.SourceID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Information");
        }
    }
}
