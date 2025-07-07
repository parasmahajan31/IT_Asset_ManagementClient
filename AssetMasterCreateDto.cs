namespace IT_Asset_ManagementClient
{
    public class AssetMasterCreateDto
    {
        public string Name { get; set; }
        public string Dept { get; set; }
        public string Product { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Warranty { get; set; }
        public string Condition { get; set; }
        public string User { get; set; }
        public string Department { get; set; }
        public bool Damaged { get; set; }
        public DateTime? DamagedDate { get; set; }
    }

}
