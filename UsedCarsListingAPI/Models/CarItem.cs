namespace UsedCarsListingAPI.Models
{
    public class CarItem
    {
        public int Id { get; set; }
        public Car Car { get; set; }
        public string Make { get; set; }
        public int KmDriven { get; set; }
        public string Owners { get; set; }
        public City City { get; set; }
        public int Price { get; set; }
        public string description { get; set; }
        public byte[] Pictures { get; set; }
        public int PostedBy { get; set; }
    }
}
