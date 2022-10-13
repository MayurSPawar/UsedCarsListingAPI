namespace UsedCarsListingAPI.Models
{
    public class TransmissionType
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}
