namespace RepairPlanning.Models
{
    public class RepairItem
    {
        public int Id { get; set; }
        public int AmountItem { get; set; }
        public int RepairId { get; set; }
        public int ItemId { get; set; }

        public Item Item { get; set; }
        public Repair Repair { get; set; }
    }
}
