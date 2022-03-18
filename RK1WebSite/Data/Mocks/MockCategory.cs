using RK1WebSite.Data.Interfaces;
using RK1WebSite.Data.Models;

namespace RK1WebSite.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>() 
                {
                    new Category()
                    {
                        Name = "Электромобили",
                        Description = "Современный вид транспорта",
                        ApiName = "electro",
                    },
                    new Category()
                    {
                        Name = "Классические автомобили",
                        Description = "Машины с двигателем внутреннего сгорания",
                        ApiName = "classic",
                    },
                };
            }
        }

        public Category? GetCategoryFromApiName(string apiName)
        {
            return AllCategories.FirstOrDefault(d => string.Equals(d.ApiName, apiName, StringComparison.OrdinalIgnoreCase));
        }
    }
}
