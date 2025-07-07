namespace IT_Asset_ManagementClient
{
    public class OpeningEntryCreateDto
    {
        public int AssetId { get; set; }
        public string Description { get; set; }
        public string Capacity { get; set; }
        public int Quantity { get; set; }
        public decimal Rate { get; set; }
        public bool Damaged { get; set; }
        public DateTime? DamagedDate { get; set; }
        public string Remarks { get; set; }
    }

}
