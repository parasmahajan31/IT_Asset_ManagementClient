namespace IT_Asset_ManagementClient
{
    public class ChallansCreateDto
    {
        public DateTime Date { get; set; }
        public int AssetId { get; set; }
        public string SerialNo { get; set; }
        public string MovementType { get; set; }
        public int Quantity { get; set; }
        public bool Damaged { get; set; }
        public DateTime? DamagedDate { get; set; }
        public string Remarks { get; set; }
    }

}
