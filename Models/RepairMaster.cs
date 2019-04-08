namespace RepairPlanning.Models
{
    public class RepairMaster
    {
        public int Id { get; set; }
        public int MasterId { get; set; }
        public int RepairId { get; set; }
        public int DaysOfWork { get; set; }

        public Repair Repair { get; set; }
        public Master Master { get; set; }
    }
}
