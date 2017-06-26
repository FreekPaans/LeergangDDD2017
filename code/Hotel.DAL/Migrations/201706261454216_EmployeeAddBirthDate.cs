namespace Hotel.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeeAddBirthDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employee", "BirthDate", c => c.DateTime(nullable: false, storeType: "date"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employee", "BirthDate");
        }
    }
}
