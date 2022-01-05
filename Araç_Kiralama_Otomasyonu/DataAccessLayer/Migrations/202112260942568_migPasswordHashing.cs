namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migPasswordHashing : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Salt", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Customers", "Password", c => c.String(nullable: false, maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Password", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.Customers", "Salt");
        }
    }
}
