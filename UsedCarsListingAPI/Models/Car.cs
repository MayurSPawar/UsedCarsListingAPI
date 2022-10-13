namespace UsedCarsListingAPI.Models
{
    public class Car
    {
        public int Id { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public Color Color { get; set; }
        public FuelType FuelType { get; set; }
        public BodyType BodyType { get; set; }
        public TransmissionType Transmission { get; set; }
    }
}
