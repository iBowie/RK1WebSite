using RK1WebSite.Data.Models;

namespace RK1WebSite.Data.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; set; }
        IEnumerable<Car> FavoriteCars { get; set; }
        Car GetObjectCar(int id); // why not 'GetCarByID'
    }
}
