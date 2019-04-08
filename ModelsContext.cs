using RepairPlanning.Models;
using System.Data.Entity;

namespace RepairPlanning
{
    class ModelsContext : DbContext
    {
        public ModelsContext() 
            : base("DbConnection")
        { }

        public DbSet<Item> Items { get; set; }
        public DbSet<ItemCategory> ItemCategories { get; set; }
        public DbSet<Master> Masters { get; set; }
        public DbSet<Repair> Repairs { get; set; }
        public DbSet<RepairItem> RepairItems { get; set; }
        public DbSet<RepairMaster> RepairMasters { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<TypeItem> TypeItems { get; set; }
        public DbSet<TypeRepair> TypeRepairs { get; set; }
    }
}
