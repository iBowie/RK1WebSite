using RK1WebSite.Data.Models;

namespace RK1WebSite.ViewModels
{
    public class CarsListViewModel
    {
        public IEnumerable<Car> AllCars { get; init; }
        public string CurrentCategory { get; init; }
    }
}
