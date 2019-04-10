namespace RepairPlanning.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeMaster : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Masters", "Name", c => c.String());
            DropColumn("dbo.Masters", "Specialization");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Masters", "Specialization", c => c.String());
            DropColumn("dbo.Masters", "Name");
        }
    }
}
