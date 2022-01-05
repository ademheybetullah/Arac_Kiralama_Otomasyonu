namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migAddImageToResvandRent : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rentings", "ImagePath", c => c.String(nullable: false, maxLength: 250));
            AddColumn("dbo.Reservations", "ImagePath", c => c.String(nullable: false, maxLength: 250));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reservations", "ImagePath");
            DropColumn("dbo.Rentings", "ImagePath");
        }
    }
}
