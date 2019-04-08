namespace RepairPlanning.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItemCategories",
                c => new
                    {
                        ItemCategoryId = c.Int(nullable: false, identity: true),
                        Name = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ItemCategoryId);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ShopId = c.Int(nullable: false),
                        TypeItemId = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        Description = c.String(),
                        WarrantyUpTo = c.DateTime(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Shops", t => t.ShopId, cascadeDelete: true)
                .ForeignKey("dbo.TypeItems", t => t.TypeItemId, cascadeDelete: true)
                .Index(t => t.ShopId)
                .Index(t => t.TypeItemId);
            
            CreateTable(
                "dbo.Shops",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PhoneNumber = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TypeItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ItemCategory_ItemCategoryId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ItemCategories", t => t.ItemCategory_ItemCategoryId)
                .Index(t => t.ItemCategory_ItemCategoryId);
            
            CreateTable(
                "dbo.Masters",
                c => new
                    {
                        MasterId = c.Int(nullable: false, identity: true),
                        Specialization = c.String(),
                        PhoneNumber = c.String(),
                        Price = c.Double(nullable: false),
                        Expiarence = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.MasterId);
            
            CreateTable(
                "dbo.RepairItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AmountItem = c.Int(nullable: false),
                        RepairId = c.Int(nullable: false),
                        ItemId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Items", t => t.ItemId, cascadeDelete: true)
                .ForeignKey("dbo.Repairs", t => t.RepairId, cascadeDelete: true)
                .Index(t => t.RepairId)
                .Index(t => t.ItemId);
            
            CreateTable(
                "dbo.Repairs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameRepair = c.String(),
                        Notes = c.String(),
                        TypeRepairId = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        ExpirationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TypeRepairs", t => t.TypeRepairId, cascadeDelete: true)
                .Index(t => t.TypeRepairId);
            
            CreateTable(
                "dbo.TypeRepairs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RepairMasters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MasterId = c.Int(nullable: false),
                        RepairId = c.Int(nullable: false),
                        DaysOfWork = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Masters", t => t.MasterId, cascadeDelete: true)
                .ForeignKey("dbo.Repairs", t => t.RepairId, cascadeDelete: true)
                .Index(t => t.MasterId)
                .Index(t => t.RepairId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RepairMasters", "RepairId", "dbo.Repairs");
            DropForeignKey("dbo.RepairMasters", "MasterId", "dbo.Masters");
            DropForeignKey("dbo.RepairItems", "RepairId", "dbo.Repairs");
            DropForeignKey("dbo.Repairs", "TypeRepairId", "dbo.TypeRepairs");
            DropForeignKey("dbo.RepairItems", "ItemId", "dbo.Items");
            DropForeignKey("dbo.Items", "TypeItemId", "dbo.TypeItems");
            DropForeignKey("dbo.TypeItems", "ItemCategory_ItemCategoryId", "dbo.ItemCategories");
            DropForeignKey("dbo.Items", "ShopId", "dbo.Shops");
            DropIndex("dbo.RepairMasters", new[] { "RepairId" });
            DropIndex("dbo.RepairMasters", new[] { "MasterId" });
            DropIndex("dbo.Repairs", new[] { "TypeRepairId" });
            DropIndex("dbo.RepairItems", new[] { "ItemId" });
            DropIndex("dbo.RepairItems", new[] { "RepairId" });
            DropIndex("dbo.TypeItems", new[] { "ItemCategory_ItemCategoryId" });
            DropIndex("dbo.Items", new[] { "TypeItemId" });
            DropIndex("dbo.Items", new[] { "ShopId" });
            DropTable("dbo.RepairMasters");
            DropTable("dbo.TypeRepairs");
            DropTable("dbo.Repairs");
            DropTable("dbo.RepairItems");
            DropTable("dbo.Masters");
            DropTable("dbo.TypeItems");
            DropTable("dbo.Shops");
            DropTable("dbo.Items");
            DropTable("dbo.ItemCategories");
        }
    }
}
