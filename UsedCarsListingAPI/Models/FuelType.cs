namespace UsedCarsListingAPI.Models
{
    public class FuelType
    {
        public int FuelTypeId { get; set; }
        public string FuelName { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}
