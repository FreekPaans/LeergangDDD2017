namespace Hotel.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeeAddLastName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employee", "LastName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employee", "LastName");
        }
    }
}
