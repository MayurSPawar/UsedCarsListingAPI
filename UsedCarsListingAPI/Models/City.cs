namespace UsedCarsListingAPI.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<CarItem> CarItems { get; set; }
    }
}
