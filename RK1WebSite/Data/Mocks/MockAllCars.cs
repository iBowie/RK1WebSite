using RK1WebSite.Data.Interfaces;
using RK1WebSite.Data.Models;

namespace RK1WebSite.Data.Mocks
{
    public class MockAllCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();

        public IEnumerable<Car> Cars 
        { 
            get
            {
                return new List<Car>()
                {
                    new Car()
                    {
                        Name = "Tesla Model S",
                        ShortDescription = "Быстрый автомобиль",
                        Description = "Красивый, быстрый и очень тихий автомобиль компании Tesla",
                        Image = "",
                        Price = 45000,
                        IsFavourite = true,
                        IsAvailable = true,
                        Category = _categoryCars.AllCategories.First(), // (╯‵□′)╯︵┻━┻
                    },
                    new Car()
                    {
                        Name = "Ford Fiesta",
                        ShortDescription = "Тихий и спокойный",
                        Description = "Удобный автомобиль для городской жизни",
                        Image = "",
                        Price = 11000,
                        IsFavourite = false,
                        IsAvailable = true,
                        Category = _categoryCars.AllCategories.Last(), // (╯‵□′)╯︵┻━┻
                    },
                    new Car() // https://cdn.discordapp.com/attachments/857230886319030272/949995601347629156/oA1IFaxp7E8.png
                    {
                        Name = "BMW M3",
                        ShortDescription = "Дерзкий и стильный",
                        Description = "Удобный автомобиль для городской жизни",
                        Image = "",
                        Price = 65000,
                        IsFavourite = true,
                        IsAvailable = true,
                        Category = _categoryCars.AllCategories.Last(), // (╯‵□′)╯︵┻━┻
                    },
                    new Car()
                    {
                        Name = "Mercedec C Class",
                        ShortDescription = "Уютный и большой",
                        Description = "Удобный автомобиль для городской жизни",
                        Image = "",
                        Price = 40000,
                        IsFavourite = false,
                        IsAvailable = false,
                        Category = _categoryCars.AllCategories.Last(), // (╯‵□′)╯︵┻━┻
                    },
                    new Car()
                    {
                        Name = "Nissan Leaf",
                        ShortDescription = "Бесшумный и экономный",
                        Description = "Удобный автомобиль для городской жизни",
                        Image = "",
                        Price = 14000,
                        IsFavourite = true,
                        IsAvailable = true,
                        Category = _categoryCars.AllCategories.First(), // (╯‵□′)╯︵┻━┻
                    },
                };
            }
            set => throw new NotImplementedException(); 
        }
        public IEnumerable<Car> FavoriteCars 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

        public Car GetObjectCar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
