namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addSaltToEmployeetbl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Salt", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "Salt");
        }
    }
}
