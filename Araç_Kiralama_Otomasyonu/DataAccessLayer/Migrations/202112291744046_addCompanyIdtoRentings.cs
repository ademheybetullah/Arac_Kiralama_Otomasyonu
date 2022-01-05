namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCompanyIdtoRentings : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rentings", "CompanyId", c => c.Int(nullable: false));
            CreateIndex("dbo.Rentings", "CompanyId");
            AddForeignKey("dbo.Rentings", "CompanyId", "dbo.Companies", "CompanyId", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rentings", "CompanyId", "dbo.Companies");
            DropIndex("dbo.Rentings", new[] { "CompanyId" });
            DropColumn("dbo.Rentings", "CompanyId");
        }
    }
}
