namespace RepairPlanning.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeStrWarrantyUpTo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Items", "WarrantyUpTo", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Items", "WarrantyUpTo", c => c.DateTime(nullable: false));
        }
    }
}
