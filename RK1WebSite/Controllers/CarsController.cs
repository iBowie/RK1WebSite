using Microsoft.AspNetCore.Mvc;
using RK1WebSite.Data.Interfaces;
using RK1WebSite.Data.Models;
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

        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        public ViewResult List(string category)
        {
            Category? targetCategory = null;

            if (!string.IsNullOrWhiteSpace(category))
            {
                targetCategory = _allCategories.GetCategoryFromApiName(category);
            }

            IEnumerable<Car> cars = 
                targetCategory is not null ? 
                _allCars.Cars.Where(d => d.CategoryID == targetCategory.ID) : 
                _allCars.Cars;

            ViewBag.Title = "Страница с автомобилями";

            CarsListViewModel viewModel = new()
            {
                AllCars = cars.OrderBy(d => d.ID),
                CurrentCategory = targetCategory?.Name ?? "Все автомобили",
            };

            return View(viewModel);
        }
    }
}
