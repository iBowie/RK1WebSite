using RK1WebSite.Data.Models;

namespace RK1WebSite.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Car> FavoriteCars { get; init; }
    }
}
