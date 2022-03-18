using Microsoft.AspNetCore.Mvc;
using RK1WebSite.Data.Interfaces;
using RK1WebSite.Data.Models;
using RK1WebSite.Data.Repository;
using RK1WebSite.ViewModels;

namespace RK1WebSite.Controllers
{
    public class ShopCartController : Controller
    {
        private readonly IAllCars _carRepository;
        private readonly ShopCart _shopCart;

        public ShopCartController(IAllCars carRepository, ShopCart shopCart)
        {
            _carRepository = carRepository;
            _shopCart = shopCart;
        }

        public ViewResult Index()
        {
            var items = _shopCart.GetCartItems();

            _shopCart.Items = items;

            var vm = new ShopCartViewModel()
            {
                ShopCart = _shopCart,
            };

            return View(vm);
        }

        public RedirectToActionResult AddToCart(int id)
        {
            var item = _carRepository.GetObjectCar(id);

            if (item is not null)
            {
                _shopCart.AddToCart(item);
            }

            return RedirectToAction("Index");
        }
    }
}
