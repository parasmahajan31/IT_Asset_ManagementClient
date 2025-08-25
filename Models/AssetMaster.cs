namespace IT_Asset_ManagementClient.Models
{
    public class AssetMaster
    {
        public int Id { get; set; } // <- Add this for primary key!
        public string Name { get; set; }

        public string Product { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Warranty { get; set; }
        public string ProductType { get; set; }
    }
}
