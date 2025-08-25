namespace IT_Asset_ManagementClient
{
    public class PurchasesCreateDto
    {
        public DateTime Date { get; set; }
        public int AssetId { get; set; }
        public int Quantity { get; set; }
        public decimal Rate { get; set; }
        public string InvoiceNo { get; set; }
        public bool Damaged { get; set; }
        public DateTime? DamagedDate { get; set; }
        public string Remarks { get; set; }
    }
}
