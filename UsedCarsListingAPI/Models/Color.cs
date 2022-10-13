namespace UsedCarsListingAPI.Models
{
    public class Color
    {
        public int ColorId { get; set; }
        public string ColorName { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}
