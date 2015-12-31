namespace Pinterest.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPinTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Url = c.String(),
                        Text = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pins", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Pins", new[] { "ApplicationUser_Id" });
            DropTable("dbo.Pins");
        }
    }
}
