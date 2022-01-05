namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reservations", "CarId", "dbo.Cars");
            DropForeignKey("dbo.Reservations", "UserId", "dbo.Customers");
            DropIndex("dbo.Reservations", new[] { "CarId" });
            DropIndex("dbo.Reservations", new[] { "UserId" });
            DropTable("dbo.Reservations");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        ReservationId = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        FinishDate = c.DateTime(nullable: false),
                        CarId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ReservationId);
            
            CreateIndex("dbo.Reservations", "UserId");
            CreateIndex("dbo.Reservations", "CarId");
            AddForeignKey("dbo.Reservations", "UserId", "dbo.Customers", "UserId", cascadeDelete: true);
            AddForeignKey("dbo.Reservations", "CarId", "dbo.Cars", "CarId", cascadeDelete: true);
        }
    }
}
