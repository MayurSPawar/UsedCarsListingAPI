using UsedCarsListingAPI.Models;

namespace UsedCarsListingAPI.Repositories
{
    public interface ICarItemRepository
    {
        Task<IEnumerable<CarItem>> GetCarItems();
        Task<CarItem> GetCarItem(int id);
        Task<CarItem> Add(CarItem carItem);
        Task Update(CarItem carItem);
        Task Delete(int id);
    }
}
