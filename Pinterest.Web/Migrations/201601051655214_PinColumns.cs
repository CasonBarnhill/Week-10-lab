namespace Pinterest.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class PinColumns : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pins", "LinkToPost", c => c.String());
            AddColumn("dbo.Pins", "LinkToImage", c => c.String());
            AddColumn("dbo.Pins", "Description", c => c.String());
            DropColumn("dbo.Pins", "Url");
            DropColumn("dbo.Pins", "Text");
        }

        public override void Down()
        {
            AddColumn("dbo.Pins", "Text", c => c.String());
            AddColumn("dbo.Pins", "Url", c => c.String());
            DropColumn("dbo.Pins", "Description");
            DropColumn("dbo.Pins", "LinkToImage");
            DropColumn("dbo.Pins", "LinkToPost");
        }
    }
}
