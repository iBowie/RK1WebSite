using Microsoft.AspNetCore.Mvc;
using RK1WebSite.Data.Interfaces;
using RK1WebSite.ViewModels;

namespace RK1WebSite.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars allCars, ICarsCategory allCategories)
        {
            _allCars = allCars;
            _allCategories = allCategories;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Страница с автомобилями";

            CarsListViewModel viewModel = new()
            {
                AllCars = _allCars.Cars,
                CurrentCategory = "Some New",
            };

            return View(viewModel);
        }
    }
}
