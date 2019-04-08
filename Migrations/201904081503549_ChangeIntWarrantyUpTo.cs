namespace RepairPlanning.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeIntWarrantyUpTo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Items", "WarrantyUpTo", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Items", "WarrantyUpTo", c => c.String());
        }
    }
}
