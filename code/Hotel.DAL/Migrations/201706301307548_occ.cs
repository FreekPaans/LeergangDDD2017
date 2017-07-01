namespace Hotel.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class occ : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DayOccupancyRecords",
                c => new
                    {
                        ForDate = c.String(nullable: false, maxLength: 128),
                        ReservationCount = c.Int(nullable: false),
                        Version = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.ForDate);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DayOccupancyRecords");
        }
    }
}
