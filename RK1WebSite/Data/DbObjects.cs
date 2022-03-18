using RK1WebSite.Data.Models;

namespace RK1WebSite.Data
{
    public class DbObjects
    {
        public static void Initial(AppDbContext context)
        {
            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Cars.Any())
            {
                context.Cars.AddRange(new List<Car>()
                {
                    new Car()
                    {
                        Name = "Tesla Model S",
                        ShortDescription = "Быстрый автомобиль",
                        Description = "Красивый, быстрый и очень тихий автомобиль компании Tesla",
                        Image = "/img/no_image.jpg",
                        Price = 45000,
                        IsFavourite = true,
                        IsAvailable = true,
                        Category = Categories["electro"], // (╯‵□′)╯︵┻━┻
                    },
                    new Car()
                    {
                        Name = "Ford Fiesta",
                        ShortDescription = "Тихий и спокойный",
                        Description = "Удобный автомобиль для городской жизни",
                        Image = "/img/no_image.jpg",
                        Price = 11000,
                        IsFavourite = false,
                        IsAvailable = true,
                        Category = Categories["classic"], // (╯‵□′)╯︵┻━┻
                    },
                    new Car() // https://cdn.discordapp.com/attachments/857230886319030272/949995601347629156/oA1IFaxp7E8.png
                    {
                        Name = "BMW M3",
                        ShortDescription = "Дерзкий и стильный",
                        Description = "Удобный автомобиль для городской жизни",
                        Image = "/img/no_image.jpg",
                        Price = 65000,
                        IsFavourite = true,
                        IsAvailable = true,
                        Category = Categories["classic"], // (╯‵□′)╯︵┻━┻
                    },
                    new Car()
                    {
                        Name = "Mercedec C Class",
                        ShortDescription = "Уютный и большой",
                        Description = "Удобный автомобиль для городской жизни",
                        Image = "/img/no_image.jpg",
                        Price = 40000,
                        IsFavourite = false,
                        IsAvailable = false,
                        Category = Categories["classic"], // (╯‵□′)╯︵┻━┻
                    },
                    new Car()
                    {
                        Name = "Nissan Leaf",
                        ShortDescription = "Бесшумный и экономный",
                        Description = "Удобный автомобиль для городской жизни",
                        Image = "/img/no_image.jpg",
                        Price = 14000,
                        IsFavourite = true,
                        IsAvailable = true,
                        Category = Categories["electro"], // (╯‵□′)╯︵┻━┻
                    },
                });
            }

            context.SaveChanges();
        }

        private static Dictionary<string, Category>? _categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                return _categories ??= new Dictionary<string, Category>()
                {
                    { 
                        "electro", 
                        new Category()
                        {
                            Name = "Электромобили",
                            Description = "Современный вид транспорта",
                        }
                    },
                    { 
                        "classic", 
                        new Category()
                        {
                            Name = "Классические автомобили",
                            Description = "Машины с двигателем внутреннего сгорания",
                        }
                    },
                };
            }
        }
    }
}
