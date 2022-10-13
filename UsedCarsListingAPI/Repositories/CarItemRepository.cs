using Microsoft.EntityFrameworkCore;
using UsedCarsListingAPI.Models;

namespace UsedCarsListingAPI.Repositories
{
    public class CarItemRepository : ICarItemRepository
    {
        public readonly CarsListingContext _context;

        public CarItemRepository(CarsListingContext context)
        {
            _context = context;
        }
        public async Task<CarItem> Add(CarItem carItem)
        {
            _context.CarItems.Add(carItem);
            await _context.SaveChangesAsync();
            return carItem;
        }

        public async Task Delete(int id)
        {
            var carItemToDelete = await _context.CarItems.FindAsync(id);
            _context.CarItems.Remove(carItemToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<CarItem> GetCarItem(int id)
        {
            return await _context.CarItems.FindAsync(id);
        }

        public async Task<IEnumerable<CarItem>> GetCarItems()
        {
            return await _context.CarItems.ToListAsync();
        }

        public async Task Update(CarItem carItem)
        {
            _context.Entry(carItem).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
