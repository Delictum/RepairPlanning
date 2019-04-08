using System;

namespace RepairPlanning.Models
{
    public class Repair
    {
        public int Id { get; set; }
        public string NameRepair { get; set; }
        public string Notes { get; set; }
        public int TypeRepairId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpirationDate { get; set; }

        public TypeRepair TypeRepair { get; set; }
    }
}
