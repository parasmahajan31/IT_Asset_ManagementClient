namespace IT_Asset_ManagementClient.Models
{
    public class Challans
    {
        public int Id { get; set; } // <- Always include Id!
        public DateTime Date { get; set; } = DateTime.Today;
        public int AssetId { get; set; } // <- Use for reference
        public string SerialNo { get; set; }
        public string MovementType { get; set; }  // Inward/Outward
        public int Quantity { get; set; }
        public bool Damaged { get; set; }
        public DateTime? DamagedDate { get; set; }
        public string Remarks { get; set; }

        // This is for display ONLY, not used in API or DB. You may populate it from code if needed:
        public string AssetName { get; set; }
    }
}
