namespace TestSolution.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifiedCustomerAttribute : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "ContactNo", c => c.String(maxLength: 15));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "ContactNo", c => c.String());
        }
    }
}
