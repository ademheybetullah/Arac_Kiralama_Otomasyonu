namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCompanyIdtoReservationstbl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservations", "CompanyId", c => c.Int(nullable: false));
            CreateIndex("dbo.Reservations", "CompanyId");
            AddForeignKey("dbo.Reservations", "CompanyId", "dbo.Companies", "CompanyId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "CompanyId", "dbo.Companies");
            DropIndex("dbo.Reservations", new[] { "CompanyId" });
            DropColumn("dbo.Reservations", "CompanyId");
        }
    }
}
