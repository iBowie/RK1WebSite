using Microsoft.AspNetCore.Mvc;
using RK1WebSite.Data.Interfaces;
using RK1WebSite.ViewModels;

namespace RK1WebSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllCars _carRep;

        public HomeController(IAllCars carRep)
        {
            _carRep = carRep;
        }

        public ViewResult Index()
        {
            var vm = new HomeViewModel()
            {
                FavoriteCars = _carRep.FavoriteCars,
            };

            return View(vm);
        }
    }
}
