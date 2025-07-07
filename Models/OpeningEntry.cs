namespace IT_Asset_ManagementClient.Models
{
    public class OpeningEntry
    {
        public int Id { get; set; }             // Primary key, identity
        public int AssetId { get; set; }        // Foreign key reference to AssetMaster
        public string Description { get; set; }
        public string Capacity { get; set; }
        public int Quantity { get; set; }
        public decimal Rate { get; set; }
        public bool Damaged { get; set; }
        public DateTime? DamagedDate { get; set; }
        public string Remarks { get; set; }

        // Optional, for display only in UI—not saved to DB
        public string AssetName { get; set; }
    }
}
