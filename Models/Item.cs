using System;

namespace RepairPlanning.Models
{
    public class Item
    {
        public int Id { get; set; }
        public int ShopId { get; set; }
        public int TypeItemId { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int WarrantyUpTo { get; set; }
        public string Name { get; set; }

        public Shop Shop { get; set; }
        public TypeItem TypeItem{ get; set; }
    }
}
