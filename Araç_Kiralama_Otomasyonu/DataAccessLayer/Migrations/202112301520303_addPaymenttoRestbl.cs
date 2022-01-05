namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPaymenttoRestbl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservations", "Payment", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reservations", "Payment");
        }
    }
}
