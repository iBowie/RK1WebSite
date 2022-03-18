using Microsoft.EntityFrameworkCore;
using RK1WebSite.Data.Interfaces;
using RK1WebSite.Data.Models;

namespace RK1WebSite.Data.Repository
{
    public class CarRepository : IAllCars
    {
        private readonly AppDbContext appDbContent;

        public CarRepository(AppDbContext appDbContent)
        {
            this.appDbContent = appDbContent;
        }

        public IEnumerable<Car> Cars 
        {
            get => appDbContent.Cars.Include(c => c.Category);
            set => throw new NotImplementedException();
        }
        public IEnumerable<Car> FavoriteCars 
        {
            get => appDbContent.Cars.Where(d => d.IsFavourite).Include(c => c.Category);
            set => throw new NotImplementedException();
        }

        public Car? GetObjectCar(int id)
        {
            return appDbContent.Cars.FirstOrDefault(d => d.ID == id);
        }
    }
}
